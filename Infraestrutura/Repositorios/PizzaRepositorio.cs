using Pizza02.Dominio.Entidades;
using Pizza02.Infraestrutura.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza02.Infraestrutura.Repositorios
{
    public class PizzaRepositorio : IPizzaRepositorio
    {
        private readonly AppDbContex _contex;

        public PizzaRepositorio(AppDbContex contex)
        {
            _contex = contex;
        }

        public void Salvar(Pizza pizza)
        {
            _contex.Pizzas.Add(pizza);
            _contex.SaveChanges();
        }

        public void Excluir(Pizza pizza)
        {
            _contex.Remove(pizza);
            _contex.SaveChanges();
        }

        public void Alterar(Pizza pizza)
        {
            var pizzaExistente = _contex.Pizzas.Find(pizza.Id);
            if (pizzaExistente == null)
            {
                throw new Exception("Pizza não existente");
            }

            pizzaExistente.SaborPizza = pizza.SaborPizza;
            pizzaExistente.Preco = pizza.Preco;
        }

        public Pizza? GetPizzaById(int id)
        {
            return _contex.Pizzas.Find(id);
        }

        public List<Pizza> GetPizza()
        {
            return _contex.Pizzas.ToList();
        }

    }
}