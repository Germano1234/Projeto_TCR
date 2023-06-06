using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCR
{
    internal class Tenista
    {
        private int idTenista;
        private string nome;
        private string contato;
        private double utr;

        public int IdPlayer { get => idTenista; set => idTenista = value; }
        public string Name { get => nome; set => nome = value; }
        public string Contact { get => contato; set => contato = value; }
        public double Utr { get => utr; set => utr = value; }
    }
}
