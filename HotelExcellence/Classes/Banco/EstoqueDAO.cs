using Classes;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Banco
{
    public class EstoqueDAO : Geral
    {
        EstoqueBLL eBLL = new EstoqueBLL();
        Conexao conexao = new Conexao();
        SqlConnection con;
        public bool Insert( string sql)
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
            finally
            {
                con.Close();
            }
            return isSucces;
        }
        public bool Pesquisa(string sql)
        {
            bool isSucces = false;
            con = new SqlConnection(conexao.Conectar());
            try
            {
                SqlCommand command = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (!reader.HasRows)
                {
                    isSucces = false;
                }
                else
                {
                    eBLL.Id = int.Parse(reader["ID"].ToString());
                    eBLL.Produto = reader["produto"].ToString();
                    eBLL.Preco = decimal.Parse(reader["preco"].ToString());
                    isSucces = true;
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                con.Close();
            }
            return isSucces;

        }
        public bool Update(string sql)
        {
            bool isSucces = false;

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
            finally {
                con.Close();
            }
            return isSucces;
        }
        public EstoqueBLL Search(string sql)
        {
            EstoqueBLL eBLL = new EstoqueBLL();
            con = new SqlConnection(conexao.Conectar());
            try
            {
                SqlCommand command = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (!reader.HasRows)
                {
                }
                else
                {
                    
                    eBLL.Produto = reader["produto"].ToString();
                    eBLL.Preco = decimal.Parse(reader["preco"].ToString());
                    eBLL.Id = int.Parse(reader["ID"].ToString());
                    eBLL.Quantidade = int.Parse(reader["quantidade"].ToString());
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                con.Close();
            }
            return eBLL;
        }
    }
}
