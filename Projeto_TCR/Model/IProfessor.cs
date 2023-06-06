using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCR.Model
{
    internal interface IProfessor
    {
        void adiciona(Professor c);
        void altera(Professor c);
        void exclui(Professor c);
        Professor GetId(int id);
        IEnumerable<Professor> GetAll();
        IEnumerable<Professor> Get(string pesquisa);
    }
}
