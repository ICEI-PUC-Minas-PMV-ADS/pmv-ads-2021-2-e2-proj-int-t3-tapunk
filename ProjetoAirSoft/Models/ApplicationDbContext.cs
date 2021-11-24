using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAirSoft.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
        }
        public DbSet<Jogadores> Jogadores { get; set; }

        public DbSet<Cadastrar> Cadastrar { get; set; }


        public DbSet<Equipes> Equipes { get; set; }

        public DbSet<Eventos> Eventos { get; set; }
    }
}
