using CobranzaAPI.Models;

namespace CobranzaAPI.Data;

public static class FakeClientes
{
    public static List<Cliente> Clientes = new()
    {
        new Cliente
        {
            CodigoCliente = 1,
            CodigoEmpresaCedente = "ECPSBL",
            IdentificacionCliente = "00001900868728",
            TipoIdentificacion = "CI",
            NombreCompleto = "JEAN CARLOS ROMERO ARMIJOS"
        },
        new Cliente
        {
            CodigoCliente = 2,
            CodigoEmpresaCedente = "GFP",
            IdentificacionCliente = "00001103362722",
            TipoIdentificacion = "PA",
            NombreCompleto = "CARLOS ROMERO"
        },
        new Cliente
        {
            CodigoCliente = 3,
            CodigoEmpresaCedente = "ECPSBL",
            IdentificacionCliente = "00001988868327",
            TipoIdentificacion = "CI",
            NombreCompleto = "EDGAR ROMERO"
        },
        new Cliente
        {
            CodigoCliente = 5,
            CodigoEmpresaCedente = "GFP",
            IdentificacionCliente = "00001777868425",
            TipoIdentificacion = "CI",
            NombreCompleto = "JUAN ROMERO"
        },
        new Cliente
        {
            CodigoCliente = 6,
            CodigoEmpresaCedente = "ECPSBL",
            IdentificacionCliente = "00001598868529",
            TipoIdentificacion = "PA",
            NombreCompleto = "LUCIA ROMERO"
        },
        new Cliente
        {
            CodigoCliente = 7,
            CodigoEmpresaCedente = "GFP",
            IdentificacionCliente = "00001412868521",
            TipoIdentificacion = "CI",
            NombreCompleto = "LUIS ROMERO"
        },


        new Cliente
        {
            CodigoCliente = 8,
            CodigoEmpresaCedente = "ECPSBL",
            IdentificacionCliente = "00001999999999",
            TipoIdentificacion = "CI",
            NombreCompleto = "MARIA FERNANDA LOPEZ"
        }        
    };
}