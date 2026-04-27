namespace CobranzaAPI.DTO;

public class ApiResponse<T>
{
    public bool Exito { get; set; }
    public string Mensaje { get; set; } = string.Empty;
    public T? Data { get; set; }
    public object? Errores { get; set; }
}