using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_TCR.Model;
using System.Data.SqlClient;

namespace Projeto_TCR.Repository
{
    internal class RAgenda
    {
        public void adiciona(Agenda p)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Server=DESKTOP-JIEU0N4\\SQLEXPRESS;Database=AgendaTCR;UID=sa;PWD=123";
            conexao.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            //cmd.CommandText = "Insert into Tenista(Nome, Contato, UTR) values(' " + c.Nome + "', '" + c.Contato + "', " + c.Utr + ")";
            cmd.CommandText = $"Insert into Agenda(Tipo, Data_Agenda, Hora, Id_Usuario, Id_Quadra) values('{p.Tipo}','{p.Data_agenda.ToShortDateString()}', '{p.Hora1}', {p.IdUsuario}, {p.IdQuadra} )";
            cmd.ExecuteNonQuery();
            conexao.Close();
        }

        public void altera(Agenda c)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Server=DESKTOP-JIEU0N4\\SQLEXPRESS;Database=AgendaTCR;UID=sa;PWD=123";
            conexao.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = $"Update Agenda set Tipo = '{c.Tipo}', Data = {c.Data_agenda}, Hora = '{c.Hora1}', Id_Ususario = {c.IdUsuario}, Id_Quadra = {c.IdQuadra} where Id_Agenda = {c.IdAgenda}";
            cmd.ExecuteNonQuery();
            conexao.Close();
        }

        public void exclui(Agenda c)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Server=DESKTOP-JIEU0N4\\SQLEXPRESS;Database=AgendaTCR;UID=sa;PWD=123";
            conexao.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = $"Delete from Agenda where Id_Agenda = {c.IdAgenda}";
            cmd.ExecuteNonQuery();
            conexao.Close();
        }

        public IEnumerable<MostrarAgenda> Get(DateTime pesquisa, int NumQuadra)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Server=DESKTOP-JIEU0N4\\SQLEXPRESS;Database=AgendaTCR;UID=sa;PWD=123";
            conexao.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = $"SELECT * FROM Agenda Where Data_Agenda = '{pesquisa.ToShortDateString()}' and Id_Quadra = {NumQuadra} ORDER BY Hora";

            SqlDataReader dr = cmd.ExecuteReader();
            List<MostrarAgenda> Lista = new List<MostrarAgenda>();

            while (dr.Read())
            {
                MostrarAgenda t = new MostrarAgenda();
                t.IdAgenda = int.Parse(dr[0].ToString());
                t.Type = dr[1].ToString();
                t.Time = dr[3].ToString();
                t.IdUser = int.Parse(dr[4].ToString());
                Lista.Add(t);
            }
            conexao.Close();
            return Lista;
        }

        public IEnumerable<Agenda> GetAll()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Server=DESKTOP-JIEU0N4\\SQLEXPRESS;Database=AgendaTCR;UID=sa;PWD=123";
            conexao.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = $"Select * from Agenda";
            SqlDataReader dr = cmd.ExecuteReader();
            List<Agenda> Lista = new List<Agenda>();

            while (dr.Read())
            {
                Agenda t = new Agenda();
                t.IdAgenda = int.Parse(dr[0].ToString());
                t.Tipo = dr[1].ToString();
                t.Data_agenda = Convert.ToDateTime(dr[2].ToString());
                t.Hora1 = dr[3].ToString();
                t.IdUsuario = int.Parse(dr[4].ToString());
                t.IdQuadra = int.Parse(dr[5].ToString());
                Lista.Add(t);
            }
            conexao.Close();
            return Lista;
        }

        public IEnumerable<int> GetQuadra(DateTime d, string t)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Server=DESKTOP-JIEU0N4\\SQLEXPRESS;Database=AgendaTCR;UID=sa;PWD=123";
            conexao.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = $"select id_quadra from Quadra where id_quadra NOT IN (select id_quadra from Agenda where Data_Agenda = '{d}' and hora = '{t}')";
            SqlDataReader dr = cmd.ExecuteReader();
            List<int> Quadras = new List<int>();

            while (dr.Read())
            {
                int quadra = int.Parse(dr[0].ToString());
                Quadras.Add(quadra);
            }
            conexao.Close();
            return Quadras;
        }

        public IEnumerable<int> GetQuadraPesquisa()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Server=DESKTOP-JIEU0N4\\SQLEXPRESS;Database=AgendaTCR;UID=sa;PWD=123";
            conexao.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = $"select id_quadra from Quadra";
            SqlDataReader dr = cmd.ExecuteReader();
            List<int> Quadras = new List<int>();

            while (dr.Read())
            {
                int quadra = int.Parse(dr[0].ToString());
                Quadras.Add(quadra);
            }
            conexao.Close();
            return Quadras;
        }

        public Agenda GetId(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Server=DESKTOP-JIEU0N4\\SQLEXPRESS;Database=AgendaTCR;UID=sa;PWD=123";
            conexao.Open();


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = $"Select * from Agenda where Id_Agenda = {id}";
            SqlDataReader dr = cmd.ExecuteReader();

            Agenda t = new Agenda();
            if (dr.Read())
            {
                t.IdAgenda = int.Parse(dr[0].ToString());
                t.IdAgenda = int.Parse(dr[0].ToString());
                t.Tipo = dr[1].ToString();
                t.Data_agenda = Convert.ToDateTime(dr[2].ToString());
                t.Hora1 = dr[3].ToString();
                t.IdUsuario = int.Parse(dr[4].ToString());
                t.IdQuadra = int.Parse(dr[5].ToString());
            }


            conexao.Close();
            return t;
        }
    }
}
