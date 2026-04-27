namespace CobranzaAPI.DTO;

public class IntencionPagoListResponse
{
    public int CodigoCliente { get; set; }
    public decimal MontoPropuesto { get; set; }
    public string Comentario { get; set; } = string.Empty;
    public DateTime FechaRegistro { get; set; }
    public bool AplicaDescuento { get; set; }
}
