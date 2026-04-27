namespace CobranzaAPI.DTO;

public class IntencionPagoResponse
{
    public int CodigoCliente { get; set; }
    public string NombreCliente { get; set; } = string.Empty;
    public int MoraMaxima { get; set; }
    public bool AplicaDescuento { get; set; }
    public string Mensaje { get; set; } = string.Empty;
}