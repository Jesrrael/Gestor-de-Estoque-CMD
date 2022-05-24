using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorEstoque
{
    internal interface IEstoque
    {
        void Exibir();
        void AdicionarEntrada();
        void AdicionarSaida();


    }
}
