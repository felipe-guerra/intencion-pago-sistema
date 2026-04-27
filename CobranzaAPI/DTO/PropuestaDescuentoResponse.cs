namespace CobranzaAPI.DTO;

public class PropuestaDescuentoResponse
{
    public int CodigoCliente { get; set; }
    public string NombreCliente { get; set; }
    public int MoraMaxima { get; set; }
    public bool AplicaDescuento { get; set; }
    public string Mensaje { get; set; }
}