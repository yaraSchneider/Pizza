using Pizza02.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza02.Dominio.Servicos
{
    public class PizzaDominioServico : IPizzaDominioServico
    {
        public void Validar(Pizza pizza)
        {
            if (string.IsNullOrEmpty(pizza.SaborPizza))
            {
                throw new Exception("Sabor é obrigatório");
            }
            if (pizza.Preco < 0)
            {
                throw new Exception("Preço deve ser maior que zero");
            }
        }

        public void ValidarId(int id)
        {
            if (id <= 0)
            {
                throw new Exception("id inválido");
            }
        }
    }
}