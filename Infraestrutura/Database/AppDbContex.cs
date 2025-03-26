using Microsoft.EntityFrameworkCore;
using Pizza02.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza02.Infraestrutura.Database
{
    public class AppDbContex : DbContext
    {
        public DbSet<Pizza> Pizzas { get; set; }

        //colocar o construtor vazio apenas depois de clocar o migrations
        public AppDbContex(DbContextOptions<AppDbContex> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "estoque_db");
            Console.WriteLine($"Banco de dados em: {path}");
            options.UseSqlite($"Data Source={path}");
        }

    }
}