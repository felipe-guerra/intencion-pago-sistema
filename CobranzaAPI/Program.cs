using Microsoft.AspNetCore.Mvc;
using CobranzaAPI.Services;
using CobranzaAPI.DTO;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers()
.ConfigureApiBehaviorOptions(options =>
{
    options.InvalidModelStateResponseFactory = context =>
    {
        var errores = context.ModelState
            .Where(x => x.Value?.Errors.Count > 0)
            .Select(x => new
            {
                Campo = x.Key,
                Error = x.Value!.Errors.First().ErrorMessage
            });

        return new BadRequestObjectResult(new ApiResponse<object>
        {
            Exito = false,
            Mensaje = "Error de validación",
            Data = null,
            Errores = errores
        });
    };
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IntencionPagoService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();