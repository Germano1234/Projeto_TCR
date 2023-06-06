using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCR.Model
{
    internal interface IQuadra
    {
        void adiciona(Quadra c);
        void altera(Quadra c);
        void exclui(Quadra c);
        Quadra GetId(int id);
        IEnumerable<Quadra> GetAll();
        IEnumerable<Quadra> Get(string pesquisa);
    }
}
