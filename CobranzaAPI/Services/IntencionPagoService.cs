using CobranzaAPI.Data;
using CobranzaAPI.DTO;
using CobranzaAPI.Models;

namespace CobranzaAPI.Services;

public class IntencionPagoService
{
    public ApiResponse<List<IntencionPagoListResponse>> ObtenerTodas()
    {
        var intenciones = FakeIntencionesPago.Intenciones ?? new List<IntencionPago>();

        var data = intenciones.Select(intencion =>
        {
            var moraMaxima = FakeOperaciones.Operaciones
                .Where(x => x.CodigoCliente == intencion.CodigoCliente)
                .Select(x => (int?)x.Mora)
                .Max() ?? 0;

            var aplica = moraMaxima > 120;

            return new IntencionPagoListResponse
            {
                CodigoCliente = intencion.CodigoCliente,
                MontoPropuesto = intencion.MontoPropuesto,
                Comentario = intencion.Comentario,
                FechaRegistro = intencion.FechaRegistro,
                AplicaDescuento = aplica
            };
        }).ToList();

        return new ApiResponse<List<IntencionPagoListResponse>>
        {
            Exito = true,
            Mensaje = "Consulta exitosa",
            Data = data,
            Errores = null
        };
    }

    public ApiResponse<IntencionPagoResponse> Registrar(IntencionPagoRequest request)
    {
        if (request.CodigoCliente <= 0)
        {
            return new ApiResponse<IntencionPagoResponse>
            {
                Exito = false,
                Mensaje = "Código de cliente inválido",
                Data = null,
                Errores = null
            };
        }

        if (request.MontoPropuesto <= 0)
        {
            return new ApiResponse<IntencionPagoResponse>
            {
                Exito = false,
                Mensaje = "El monto propuesto debe ser mayor a 0",
                Data = null,
                Errores = null
            };
        }

        if (string.IsNullOrWhiteSpace(request.Comentario))
        {
            return new ApiResponse<IntencionPagoResponse>
            {
                Exito = false,
                Mensaje = "El comentario es obligatorio",
                Data = null,
                Errores = null
            };
        }

        var cliente = FakeClientes.Clientes
            .FirstOrDefault(x => x.CodigoCliente == request.CodigoCliente);

        if (cliente == null)
        {
            return new ApiResponse<IntencionPagoResponse>
            {
                Exito = false,
                Mensaje = "Cliente no encontrado",
                Data = null,
                Errores = null
            };
        }

        var moraMaxima = FakeOperaciones.Operaciones
            .Where(x => x.CodigoCliente == request.CodigoCliente)
            .Select(x => (int?)x.Mora)
            .Max() ?? 0;

        var aplica = moraMaxima > 120;

        var intencion = new IntencionPago
        {
            CodigoCliente = request.CodigoCliente,
            MontoPropuesto = request.MontoPropuesto,
            Comentario = request.Comentario,
            FechaRegistro = DateTime.Now
        };

        FakeIntencionesPago.Intenciones.Add(intencion);

        var response = new IntencionPagoResponse
        {
            CodigoCliente = request.CodigoCliente,
            NombreCliente = cliente.NombreCompleto,
            MoraMaxima = moraMaxima,
            AplicaDescuento = aplica,
            Mensaje = aplica
                ? "Cliente califica para campaña de descuento"
                : "Cliente no califica para descuento"
        };

        return new ApiResponse<IntencionPagoResponse>
        {
            Exito = true,
            Mensaje = "Operación realizada correctamente",
            Data = response,
            Errores = null
        };
    }

    public ApiResponse<IntencionPagoResponse> EvaluarDescuento(int codigoCliente)
    {
        var cliente = FakeClientes.Clientes
            .FirstOrDefault(x => x.CodigoCliente == codigoCliente);

        if (cliente == null)
        {
            return new ApiResponse<IntencionPagoResponse>
            {
                Exito = false,
                Mensaje = "Cliente no encontrado",
                Data = null,
                Errores = null
            };
        }

        var moraMaxima = FakeOperaciones.Operaciones
            .Where(x => x.CodigoCliente == codigoCliente)
            .Select(x => (int?)x.Mora)
            .Max() ?? 0;

        var aplica = moraMaxima > 120;

        var response = new IntencionPagoResponse
        {
            CodigoCliente = codigoCliente,
            NombreCliente = cliente.NombreCompleto,
            MoraMaxima = moraMaxima,
            AplicaDescuento = aplica,
            Mensaje = aplica
                ? "Cliente califica para campaña de descuento"
                : "Cliente no califica para descuento"
        };

        return new ApiResponse<IntencionPagoResponse>
        {
            Exito = true,
            Mensaje = "Consulta exitosa",
            Data = response,
            Errores = null
        };
    }
}