using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public class Geral
    {
        Conexao conexao = new Conexao();
        SqlConnection con;
        public DataTable BuscandoTudo(string sql)
        {
            con = new SqlConnection(conexao.Conectar());
            DataTable dt = new DataTable();
            try
            {
                SqlCommand command = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                dt.Load(reader);
                /*DataRow row = dt.NewRow();
                row["id"] = "";
                dt.Rows.InsertAt(row, 0);*/
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
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
            catch (Exception)
            {
            }
            finally { con.Close(); }
            return isSucess;
        } /*DELETANDO UM CADASTRO ESPECIFICO NO BANCO DE DADOS*/
    }
}
