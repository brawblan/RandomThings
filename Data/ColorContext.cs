using Microsoft.EntityFrameworkCore;

namespace RandomThings.Data;

public class ColorContext(DbContextOptions<ColorContext> options) : DbContext(options)
{
    public DbSet<Models.Color> Color { get; set; } = default!;
}
