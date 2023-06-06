using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCR
{
    internal class Quadra
    {
        private int idQuadra;
        private string piso;
        private string cobertura;

        public int IdCourt { get => idQuadra; set => idQuadra = value; }
        public string Surface { get => piso; set => piso = value; }
        public string Covered { get => cobertura; set => cobertura = value; }
    }
}
