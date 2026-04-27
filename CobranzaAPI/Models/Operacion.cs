namespace CobranzaAPI.Models;

public class Operacion
{
    public int IdOperacion { get; set; }
    public int CodigoCliente { get; set; }
    public int Mora { get; set; }
    public string Estado { get; set; }
}