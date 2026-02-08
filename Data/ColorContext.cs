using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RandomThings.Models;

    public class ColorContext : DbContext
    {
        public ColorContext (DbContextOptions<ColorContext> options)
            : base(options)
        {
        }

        public DbSet<RandomThings.Models.Color> Color { get; set; } = default!;
    }
