using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCR.Model
{
    internal interface ITenista
    {
        void adiciona(Tenista c);
        void altera(Tenista c);
        void exclui(Tenista c);
        Tenista GetId(int id);
        IEnumerable<Tenista> GetAll();
        IEnumerable<Tenista> Get(string pesquisa);


    }
}
