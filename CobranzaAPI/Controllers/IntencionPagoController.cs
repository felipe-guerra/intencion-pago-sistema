using Microsoft.AspNetCore.Mvc;
using CobranzaAPI.DTO;
using CobranzaAPI.Services;

namespace CobranzaAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class IntencionPagoController : ControllerBase
{
    private readonly IntencionPagoService _service;

    public IntencionPagoController(IntencionPagoService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var result = _service.ObtenerTodas();

        return Ok(result);
    }

    [HttpPost]
    public IActionResult Post([FromBody] IntencionPagoRequest request)
    {
        var result = _service.Registrar(request);

        if (!result.Exito)
            return BadRequest(result);

        return Ok(result);
    }
}