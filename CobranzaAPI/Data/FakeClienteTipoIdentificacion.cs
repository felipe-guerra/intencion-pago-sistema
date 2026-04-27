using CobranzaAPI.Models;

namespace CobranzaAPI.Data;

public static class FakeClienteTipoIdentificacion
{
    public static List<ClienteTipoIdentificacion> Registros = new()
    {
        new ClienteTipoIdentificacion
        {
            CodigoEmpresaCedente = "ECPSBL",
            IdentificacionCliente = "00001900868728",
            Fecha = new DateTime(2024, 01, 18),
            TipoIdentificacion = "CI"
        },
        new ClienteTipoIdentificacion
        {
            CodigoEmpresaCedente = "GFP",
            IdentificacionCliente = "00001103362722",
            Fecha = new DateTime(2024, 01, 18),
            TipoIdentificacion = "CI"
        },
        new ClienteTipoIdentificacion
        {
            CodigoEmpresaCedente = "ECPSBL",
            IdentificacionCliente = "00001988868327",
            Fecha = new DateTime(2024, 01, 18),
            TipoIdentificacion = "CI"
        },
        new ClienteTipoIdentificacion
        {
            CodigoEmpresaCedente = "GFP",
            IdentificacionCliente = "00001777868425",
            Fecha = new DateTime(2024, 01, 18),
            TipoIdentificacion = "CI"
        },
        new ClienteTipoIdentificacion
        {
            CodigoEmpresaCedente = "ECPSBL",
            IdentificacionCliente = "00001598868529",
            Fecha = new DateTime(2024, 01, 18),
            TipoIdentificacion = "PA"
        },
        new ClienteTipoIdentificacion
        {
            CodigoEmpresaCedente = "GFP",
            IdentificacionCliente = "00001412868521",
            Fecha = new DateTime(2024, 01, 18),
            TipoIdentificacion = "CI"
        },


        new ClienteTipoIdentificacion
        {
            CodigoEmpresaCedente = "ECPSBL",
            IdentificacionCliente = "00001999999999",
            Fecha = new DateTime(2024, 01, 18),
            TipoIdentificacion = "CI"
        }        
    };
}