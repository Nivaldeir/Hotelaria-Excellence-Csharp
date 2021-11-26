using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Banco
{
    public class Geral
    {
        Conexao conexao = new Conexao();
        SqlConnection con;
        public DataTable BuscandoTudo(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                con = new SqlConnection(conexao.Conectar());
               
                SqlCommand command = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                dt.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                con.Close();
            }
            return dt;
        } /*PEGANDO TODAS AS INFORMACOES DO BANDO DE DADOS*/

        public bool Deletando(string sql)
        {
            bool isSucess = false;
           con = new SqlConnection(conexao.Conectar());
            try
            { 
                SqlCommand command = new SqlCommand(sql, con);
                con.Open();
                int rows = command.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSucess = true;
                }
                else
                {
                    isSucess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
            return isSucess;
        } /*DELETANDO UM CADASTRO ESPECIFICO NO BANCO DE DADOS*/
    }
}
