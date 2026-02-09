using Microsoft.EntityFrameworkCore;
using RandomThings.Data;

// Add services to the container.
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ColorContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ColorContext") ?? throw new InvalidOperationException("Connection string 'ColorContext' not found.")));
builder.Services.AddControllers();
builder.Services.AddOpenApiDocument();

var app = builder.Build();

// There is no database so it's okay to have all endpionts available via swagger.
app.UseOpenApi();
app.UseSwaggerUi(options =>
{
    options.DocumentPath = "/swagger/v1/swagger.json";
    options.Path = "";
});

// Middleware
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

//
app.Run();
