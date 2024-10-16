using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCR.Model
{
    internal interface IAgenda
    {
        void adiciona(Agenda c);
        void altera(Agenda c);
        void exclui(Agenda c);
        Agenda GetId(int id);
        IEnumerable<MostrarAgenda> Get(DateTime pesquisa, int NumQuadra);
        IEnumerable<Agenda> GetAll();
        IEnumerable<int> GetQuadraPesquisa();
        IEnumerable<int> GetQuadra(DateTime d, string t);
    }
}
