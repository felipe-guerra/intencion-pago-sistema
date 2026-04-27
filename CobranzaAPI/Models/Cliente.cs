namespace CobranzaAPI.Models;

public class Cliente
{
    public int CodigoCliente { get; set; }
    public string CodigoEmpresaCedente { get; set; }
    public string IdentificacionCliente { get; set; }
    public string TipoIdentificacion { get; set; }
    public string NombreCompleto { get; set; }
}