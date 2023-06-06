using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCR
{
    internal class Professor
    {
        private int idProfessor;
        private string nome;
        private string contato;
        private string nivel;

        public int IdTeacher { get => idProfessor; set => idProfessor = value; }
        public string Name { get => nome; set => nome = value; }
        public string Contact { get => contato; set => contato = value; }
        public string Level { get => nivel; set => nivel = value; }
    }
}
