using Pizza02.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza02.Infraestrutura.Repositorios
{
    public interface IPizzaRepositorio
    {
        void Salvar(Pizza pizza);
        void Excluir(Pizza pizza);
        void Alterar(Pizza pizza);

        Pizza? GetPizzaById(int id);
        List<Pizza> GetPizza();
    }
}