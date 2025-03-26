using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza02.Dominio.Entidades
{
    public class Pizza
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Column("saborPizza")]
        public string SaborPizza { get; set; }

        [Required]
        public decimal Preco { get; set; }

        public Pizza(string saborPizza, decimal preco) {
           
            SaborPizza = saborPizza;
            Preco = preco;
        }

        public Pizza(int id, string saborPizza, decimal preco) {
            
            Id = id;
            SaborPizza = saborPizza;
            Preco = preco;
        }

    }
}
