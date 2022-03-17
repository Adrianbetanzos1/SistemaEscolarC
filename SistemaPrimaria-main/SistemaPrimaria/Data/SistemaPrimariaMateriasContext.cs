using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaPrimaria.Models;

namespace SistemaPrimaria.Data
{
    public class SistemaPrimariaMateriasContext : DbContext
    {
        public SistemaPrimariaMateriasContext (DbContextOptions<SistemaPrimariaMateriasContext> options)
            : base(options)
        {
        }

        public DbSet<SistemaPrimaria.Models.Materias> Materias { get; set; }
    }
}
