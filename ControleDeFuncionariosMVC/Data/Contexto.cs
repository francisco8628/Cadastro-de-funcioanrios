using ControleDeFuncionariosMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleDeFuncionariosMVC.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
        : base(options)
        { }

        public DbSet<Funcionario> Usuario { get; set; }

        public DbSet<Cargo> Cargo { get; set; }
    }
}
