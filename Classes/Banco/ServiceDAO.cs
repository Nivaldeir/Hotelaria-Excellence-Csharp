using Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Banco
{
    public class ServiceDAO : Geral
    {
        Conexao conexao = new Conexao();
        SqlConnection con;
        public bool Insert(ServicesBLL sBLL)
        {
            bool isSucess = false;
            con = new SqlConnection(conexao.Conectar());
            try
            {
                string sql = "INSERT INTO tbl_ServicoConsumo (valor, servico, ID_ESTOQUE, ID_DEPARTAMENTE, quantidade) Values (@valor, @servico, " + sBLL.idEstoque+", "+ sBLL.idDepartamento+", @quantidade)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@valor", sBLL.Valor);
                cmd.Parameters.AddWithValue("@servico", sBLL.Servico);
                cmd.Parameters.AddWithValue("@quantidade", sBLL.Quantidade);
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSucess = true;
                }
                else
                {
                    isSucess = false;
                }
                con.Close();
            }
            catch (Exception )
            {
            }
            return isSucess;
        }
    }

}
