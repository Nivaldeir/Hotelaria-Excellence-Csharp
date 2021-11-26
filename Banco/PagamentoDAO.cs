using Classes;
using System;
using System.Data.SqlClient;

namespace Banco
{
    public class PagamentoDAO : Geral
    {
        Conexao conexao = new Conexao();
        SqlConnection con;
        public bool cadastrarPagamento(PagamentoBLL pBLL, string sql)
        {
            bool isSucces = false;
            con = new SqlConnection(conexao.Conectar());
            try
            {
                /*string sql = "INSERT INTO tbl_FormaPagamento(forma_pagamento, valor) VALUES(@forma_pagamento, @valor)";
               
                cmd.Parameters.AddWithValue("@forma_pagamento", pBLL.formaPagamento);
                cmd.Parameters.AddWithValue("@valor", pBLL.Valor);*/
                con.Open();
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
    }
}
