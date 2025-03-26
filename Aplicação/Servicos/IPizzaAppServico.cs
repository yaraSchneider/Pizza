using Pizza02.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza02.Aplicação.Servicos
{
    public interface IPizzaAppServico
    {

        void CadastrarPizza(string sabor, decimal preco);
        void AlterarPizza(int id, string sabor, decimal preco);
        void ExcluirPizza(Pizza pizza);
        List<Pizza> GetPizza();


    }
}