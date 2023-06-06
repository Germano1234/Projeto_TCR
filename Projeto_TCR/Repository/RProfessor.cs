using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_TCR.Model;
using System.Data.SqlClient;

namespace Projeto_TCR.Repository
{
    internal class RProfessor : IProfessor
    {
        public void adiciona(Professor p)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Server=DESKTOP-JIEU0N4\\SQLEXPRESS;Database=AgendaTCR;UID=sa;PWD=123";
            conexao.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            //cmd.CommandText = "Insert into Tenista(Nome, Contato, UTR) values(' " + c.Nome + "', '" + c.Contato + "', " + c.Utr + ")";
            cmd.CommandText = $"Insert into Professor(Nome, Contato, Nivel) values('{p.Name}','{p.Contact}', '{p.Level}' )";
            cmd.ExecuteNonQuery();
            conexao.Close();
        }

        public void altera(Professor c)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Server=DESKTOP-JIEU0N4\\SQLEXPRESS;Database=AgendaTCR;UID=sa;PWD=123";
            conexao.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = $"Update Professor set Nome = '{c.Name}', Contato = '{c.Contact}', Nivel = '{c.Level}' where Id_Professor = {c.IdTeacher}";
            cmd.ExecuteNonQuery();
            conexao.Close();
        }

        public void exclui(Professor c)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Server=DESKTOP-JIEU0N4\\SQLEXPRESS;Database=AgendaTCR;UID=sa;PWD=123";
            conexao.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = $"Delete from Professor where Id_Professor = {c.IdTeacher}";
            cmd.ExecuteNonQuery();
            conexao.Close();
        }

        public IEnumerable<Professor> Get(string pesquisa)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Server=DESKTOP-JIEU0N4\\SQLEXPRESS;Database=AgendaTCR;UID=sa;PWD=123";
            conexao.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = $"Select * from Professor where Nome like '{pesquisa}%'";

            SqlDataReader dr = cmd.ExecuteReader();
            List<Professor> Lista = new List<Professor>();

            while (dr.Read())
            {
                Professor t = new Professor();
                t.IdTeacher = int.Parse(dr[0].ToString());
                t.Name = dr[1].ToString();
                t.Contact = dr[2].ToString();
                t.Level = dr[3].ToString();
                Lista.Add(t);
            }
            conexao.Close();
            return Lista;
        }

        public IEnumerable<Professor> GetAll()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Server=DESKTOP-JIEU0N4\\SQLEXPRESS;Database=AgendaTCR;UID=sa;PWD=123";
            conexao.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = $"Select * from Professor";
            SqlDataReader dr = cmd.ExecuteReader();
            List<Professor> Lista = new List<Professor>();

            while (dr.Read())
            {
                Professor t = new Professor();
                t.IdTeacher = int.Parse(dr[0].ToString());
                t.Name = dr[1].ToString();
                t.Contact = dr[2].ToString();
                t.Level = dr[3].ToString();
                Lista.Add(t);
            }
            conexao.Close();
            return Lista;
        }

        public Professor GetId(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Server=DESKTOP-JIEU0N4\\SQLEXPRESS;Database=AgendaTCR;UID=sa;PWD=123";
            conexao.Open();


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = $"Select * from Professor where Id_Professor = {id}";
            SqlDataReader dr = cmd.ExecuteReader();

            Professor t = new Professor();
            if (dr.Read())
            {
                t.IdTeacher = int.Parse(dr[0].ToString());
                t.Name = dr[1].ToString();
                t.Contact = dr[2].ToString();
                t.Level = dr[3].ToString();
            }


            conexao.Close();
            return t;
        }
    }
}
