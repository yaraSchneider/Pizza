using Pizza02.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza02.Dominio.Servicos
{
    public interface IPizzaDominioServico
    {
        void Validar(Pizza pizza);
        void ValidarId(int id);
    }
}
