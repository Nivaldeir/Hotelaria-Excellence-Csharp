using Classes;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Banco
{
    public class PagamentoDAO : Geral
    {
        Conexao conexao = new Conexao();
        SqlConnection con;
        public bool cadastrarPagamento(PagamentoBLL pBLL)
        {
            bool isSucces = false;
            con = new SqlConnection(conexao.Conectar());
            try
            {
                string sql = "INSERT INTO tbl_FormaPagamento(forma_pagamento, valor) VALUES(@forma_pagamento, @valor)";
                SqlCommand command = new SqlCommand(sql, con);
           
                command.Parameters.AddWithValue("@forma_pagamento", pBLL.formaPagamento);
                command.Parameters.AddWithValue("@valor", pBLL.Valor);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return isSucces;
        }
    }
}
