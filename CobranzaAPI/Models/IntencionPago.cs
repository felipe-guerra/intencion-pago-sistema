namespace CobranzaAPI.Models;

public class IntencionPago
{
    public int CodigoCliente { get; set; }
    public decimal MontoPropuesto { get; set; }
    public string Comentario { get; set; }
    public DateTime FechaRegistro { get; set; } = DateTime.Now;
}