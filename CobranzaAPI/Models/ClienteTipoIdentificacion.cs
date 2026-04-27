namespace CobranzaAPI.Models;

public class ClienteTipoIdentificacion
{
    public string CodigoEmpresaCedente { get; set; }
    public string IdentificacionCliente { get; set; }
    public DateTime Fecha { get; set; }
    public string TipoIdentificacion { get; set; }
}