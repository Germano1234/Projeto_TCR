using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TCR.Model
{
    internal class Agenda
    {
        private int idAgenda;
        private string tipo;
        private DateTime data_agenda;
        private string Hora;
        private int id;
        private int idUsuario;
        private int idQuadra;

        public int IdAgenda { get => idAgenda; set => idAgenda = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public DateTime Data_agenda { get => data_agenda; set => data_agenda = value; }
        public string Hora1 { get => Hora; set => Hora = value; }
        public int Id { get => id; set => id = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int IdQuadra { get => idQuadra; set => idQuadra = value; }
    }
}
