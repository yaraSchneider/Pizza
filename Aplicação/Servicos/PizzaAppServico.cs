using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizza02.Dominio.Entidades;
using Pizza02.Dominio.Servicos;
using Pizza02.Infraestrutura.Repositorios;

namespace Pizza02.Aplicação.Servicos
{
    public class PizzaAppServico : IPizzaAppServico
    {
        private readonly IPizzaDominioServico _dominioServico;
        private readonly IPizzaRepositorio _pizzaRepositorio;

        public PizzaAppServico(IPizzaDominioServico dominioServico, IPizzaRepositorio pizzaRepositorio)
        {
            _dominioServico = dominioServico;
            _pizzaRepositorio = pizzaRepositorio;
        }

        public void CadastrarPizza(string saborPizza, decimal preco)
        {
            var pizza = new Pizza(saborPizza, preco);
            _dominioServico.Validar(pizza);
            _pizzaRepositorio.Salvar(pizza);
        }

        public void AlterarPizza(int id, string saborPizza, decimal preco)
        {
            _dominioServico.ValidarId(id);

            var pizzaExistente = _pizzaRepositorio.GetPizzaById(id);
            if (pizzaExistente == null)
            {
                throw new Exception("Produto não encontrado para alteração");
            }

            pizzaExistente.SaborPizza = saborPizza;
            pizzaExistente.Preco = preco;

            _dominioServico.Validar(pizzaExistente);
            _pizzaRepositorio.Alterar(pizzaExistente);
        }

        public void ExcluirPizza(Pizza pizza)
        {
            var pizzaExistente = _pizzaRepositorio.GetPizzaById(pizza.Id);
            if (pizzaExistente == null)
            {
                throw new Exception("Produto não encontrado para alteração");
            }

            _pizzaRepositorio.Excluir(pizzaExistente);
        }

        public List<Pizza> GetPizza()
        {
            return _pizzaRepositorio.GetPizza();
        }
    }
}