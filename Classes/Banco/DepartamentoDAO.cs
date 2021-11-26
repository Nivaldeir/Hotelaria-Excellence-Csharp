using Classes;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Banco
{
    public class DepartamentoDAO : Geral
    {
        Conexao conexao = new Conexao();
        SqlConnection con;
        DepartamentoBLL dBLL;
        public bool Insert(string sql)
        {
            bool isSucces = false;
            con = new SqlConnection(conexao.Conectar());
            try
            {
                SqlCommand command = new SqlCommand(sql, con);
                con.Open();
                int rows = command.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSucces = true;
                }
                else
                {
                    isSucces = false;
                }
            }
            catch (Exception)
            {
            }
            finally { con.Close(); }
            return isSucces;
        }
        public bool Update(string sql)
        {
            bool isSucces = false;
            try
            {
                SqlCommand command = new SqlCommand(sql, con);
                con.Open();
                con.Open();
                int rows = command.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSucces = true;
                }
                else
                {
                    isSucces = false;
                }
            }
            catch (Exception)
            {
            }
            finally { con.Close(); }
            return isSucces;
        }
       
        public DepartamentoBLL Pesquisa(string sql)
        {
            dBLL = new DepartamentoBLL();
            con = new SqlConnection(conexao.Conectar());
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand(sql, con);
                SqlDataReader reader = command.ExecuteReader();
                
                reader.Read();
                if (!reader.HasRows)
                {
                }
                else
                {
                    dBLL.Id = int.Parse(reader["id"].ToString());
                    dBLL.Nome = reader["nome"].ToString();
                }
            }
            catch (Exception)
            {
            }
            finally {
                con.Close();
            }
            return dBLL;
        }
    }
}
