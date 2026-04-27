namespace CobranzaAPI.DTO;

using System.ComponentModel.DataAnnotations;

public class IntencionPagoRequest
{
    [Required]
    public int CodigoCliente { get; set; }

    [Required]
    [Range(1, double.MaxValue)]
    public decimal MontoPropuesto { get; set; }

    [Required]
    [MinLength(1)]
    public string Comentario { get; set; } = string.Empty;
}