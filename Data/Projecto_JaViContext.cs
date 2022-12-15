using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projecto_JaVi.Models;

namespace Projecto_JaVi.Data
{
    public class Projecto_JaViContext : DbContext
    {
        public Projecto_JaViContext (DbContextOptions<Projecto_JaViContext> options)
            : base(options)
        {
        }

        public DbSet<Projecto_JaVi.Models.Contacto> Contacto { get; set; } = default!;

        public DbSet<Projecto_JaVi.Models.Filme> Filme { get; set; } = default!;

        public DbSet<Projecto_JaVi.Models.Serie> Serie { get; set; } = default!;
    }
}
