using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_TCR.Model;
using System.Data.SqlClient;

namespace Projeto_TCR.Repository
{
    internal class RQuadra : IQuadra
    {
        public void adiciona(Quadra c)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Server=DESKTOP-JIEU0N4\\SQLEXPRESS;Database=AgendaTCR;UID=sa;PWD=123";
            conexao.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            //cmd.CommandText = "Insert into Tenista(Nome, Contato, UTR) values(' " + c.Nome + "', '" + c.Contato + "', " + c.Utr + ")";
            cmd.CommandText = $"Insert into Quadra (Piso, Coberta) values('{c.Surface}','{c.Covered}')";
            cmd.ExecuteNonQuery();
            conexao.Close();
        }

        public void altera(Quadra c)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Server=DESKTOP-JIEU0N4\\SQLEXPRESS;Database=AgendaTCR;UID=sa;PWD=123";
            conexao.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = $"Update Quadra set Piso = '{c.Surface}', Coberta = '{c.Covered}' where Id_Quadra = {c.IdCourt}";
            cmd.ExecuteNonQuery();
            conexao.Close();
        }

        public void exclui(Quadra c)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Server=DESKTOP-JIEU0N4\\SQLEXPRESS;Database=AgendaTCR;UID=sa;PWD=123";
            conexao.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = $"Delete from Quadra where Id_Quadra = {c.IdCourt}";
            cmd.ExecuteNonQuery();
            conexao.Close();
        }

        public IEnumerable<Quadra> Get(string pesquisa)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Server=DESKTOP-JIEU0N4\\SQLEXPRESS;Database=AgendaTCR;UID=sa;PWD=123";
            conexao.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = $"Select * from Quadra where Piso like '{pesquisa}%'";

            SqlDataReader dr = cmd.ExecuteReader();
            List<Quadra> Lista = new List<Quadra>();

            while (dr.Read())
            {
                Quadra t = new Quadra();
                t.IdCourt = int.Parse(dr[0].ToString());
                t.Surface = dr[1].ToString();
                t.Covered = dr[2].ToString();
                Lista.Add(t);
            }
            conexao.Close();
            return Lista;
        }

        public IEnumerable<Quadra> GetAll()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Server=DESKTOP-JIEU0N4\\SQLEXPRESS;Database=AgendaTCR;UID=sa;PWD=123";
            conexao.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = $"Select * from Quadra";
            SqlDataReader dr = cmd.ExecuteReader();
            List<Quadra> Lista = new List<Quadra>();

            while (dr.Read())
            {
                Quadra t = new Quadra();
                t.IdCourt = int.Parse(dr[0].ToString());
                t.Surface = dr[1].ToString();
                t.Covered = dr[2].ToString();
                Lista.Add(t);
            }
            conexao.Close();
            return Lista;
        }

        public Quadra GetId(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Server=DESKTOP-JIEU0N4\\SQLEXPRESS;Database=AgendaTCR;UID=sa;PWD=123";
            conexao.Open();


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = $"Select * from Quadra where Id_Quadra = {id}";
            SqlDataReader dr = cmd.ExecuteReader();

            Quadra t = new Quadra();
            if (dr.Read())
            {
                t.IdCourt = int.Parse(dr[0].ToString());
                t.Surface = dr[1].ToString();
                t.Covered = dr[2].ToString();
            }


            conexao.Close();
            return t;
        }
    }
}
