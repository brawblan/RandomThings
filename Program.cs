using Microsoft.AspNetCore.OpenApi;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

// Add services to the container.
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ColorContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ColorContext") ?? throw new InvalidOperationException("Connection string 'ColorContext' not found.")));
builder.Services.AddControllers();
builder.Services.AddOpenApiDocument();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseOpenApi();
    app.UseSwaggerUi(options =>
    {
        options.DocumentPath = "/swagger/v1/swagger.json";
    });
}

// Middleware
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

//
app.Run();
