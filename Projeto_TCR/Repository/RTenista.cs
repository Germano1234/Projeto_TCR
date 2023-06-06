using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_TCR.Model;
using System.Data.SqlClient;

namespace Projeto_TCR.Repository
{
    internal class RTenista : ITenista
    {
        public void adiciona(Tenista c)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Server=DESKTOP-JIEU0N4\\SQLEXPRESS;Database=AgendaTCR;UID=sa;PWD=123";
            conexao.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            //cmd.CommandText = "Insert into Tenista(Nome, Contato, UTR) values(' " + c.Nome + "', '" + c.Contato + "', " + c.Utr + ")";
            cmd.CommandText = $"Insert into Tenista(Nome, Contato, UTR) values('{c.Name}','{c.Contact}', {c.Utr} )";
            cmd.ExecuteNonQuery();
            conexao.Close();
        }

        public void altera(Tenista c)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Server=DESKTOP-JIEU0N4\\SQLEXPRESS;Database=AgendaTCR;UID=sa;PWD=123";
            conexao.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = $"Update Tenista set Nome = '{c.Name}', Contato = '{c.Contact}', UTR = {c.Utr} where Id_Tenista = {c.IdPlayer}";
            cmd.ExecuteNonQuery();
            conexao.Close();
        }

        public void exclui(Tenista c)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Server=DESKTOP-JIEU0N4\\SQLEXPRESS;Database=AgendaTCR;UID=sa;PWD=123";
            conexao.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = $"Delete from Tenista where Id_Tenista = {c.IdPlayer}";
            cmd.ExecuteNonQuery();
            conexao.Close();
        }

        public IEnumerable<Tenista> Get(string pesquisa)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Server=DESKTOP-JIEU0N4\\SQLEXPRESS;Database=AgendaTCR;UID=sa;PWD=123";
            conexao.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = $"Select * from Tenista where Nome like '{pesquisa}%'";

            SqlDataReader dr = cmd.ExecuteReader();
            List<Tenista> Lista = new List<Tenista>();

            while (dr.Read())
            {
                Tenista t = new Tenista();
                t.IdPlayer = int.Parse(dr[0].ToString());
                t.Name = dr[1].ToString();
                t.Contact = dr[2].ToString();
                t.Utr = float.Parse(dr[3].ToString());
                Lista.Add(t);
            }
            conexao.Close();
            return Lista;
        }

        public IEnumerable<Tenista> GetAll()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Server=DESKTOP-JIEU0N4\\SQLEXPRESS;Database=AgendaTCR;UID=sa;PWD=123";
            conexao.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = $"Select * from Tenista";
            SqlDataReader dr = cmd.ExecuteReader();
            List<Tenista> Lista = new List<Tenista>();

            while (dr.Read())
            {
                Tenista t = new Tenista();
                t.IdPlayer = int.Parse(dr[0].ToString());
                t.Name = dr[1].ToString();
                t.Contact = dr[2].ToString();
                t.Utr = float.Parse(dr[3].ToString());
                Lista.Add(t);
            }
            conexao.Close();
            return Lista;
        }

        public Tenista GetId(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Server=DESKTOP-JIEU0N4\\SQLEXPRESS;Database=AgendaTCR;UID=sa;PWD=123";
            conexao.Open();


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = $"Select * from Tenista where Id_Tenista = {id}";
            SqlDataReader dr = cmd.ExecuteReader();

            Tenista t = new Tenista();
            if (dr.Read())
            {
                t.IdPlayer = int.Parse(dr[0].ToString());
                t.Name = dr[1].ToString();
                t.Contact = dr[2].ToString();
                t.Utr = float.Parse(dr[3].ToString());
            }
            

            conexao.Close();
            return t;
        }
    }
}
