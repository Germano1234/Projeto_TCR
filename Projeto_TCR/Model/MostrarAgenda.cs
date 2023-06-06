using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCR.Model
{
    internal class MostrarAgenda
    {
        private int idAgenda;
        private string tipo;
        private string Hora;
        private int idUsuario;

        public int IdAgenda { get => idAgenda; set => idAgenda = value; }
        public string Type { get => tipo; set => tipo = value; }
        public string Time { get => Hora; set => Hora = value; }
        public int IdUser { get => idUsuario; set => idUsuario = value; }
 
    }
}
