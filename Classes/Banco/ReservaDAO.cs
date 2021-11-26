
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Banco;
using Classes;

namespace Banco
{
    public class ReservaDAO : Geral
    {
        Conexao conexao = new Conexao();
        SqlConnection con;
        public ReservaBLL buscarReserva(string sql)
        {
            ReservaBLL rBLL = new ReservaBLL();
            con = new SqlConnection(conexao.Conectar());
            try
            {
                SqlCommand command = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    rBLL.ID = int.Parse(reader["ID"].ToString());
                    rBLL.Reserva = DateTime.Parse(reader["reserva"].ToString());
                    rBLL.Quarto = reader["Quarto"].ToString();
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                con.Close();
            }
            return rBLL;
        }

        public bool cadastrarReserva(ReservaBLL rBLL)
        {
            bool isSuccess = false;
            con = new SqlConnection(conexao.Conectar());
            try
            {
                string sql = "INSERT INTO tbl_Reserva (reserva, ID_QUARTO, ID_HOSPEDE, ID_FORMA_PAGAMENTO) VALUES (@reserva, @ID_QUARTO, @ID_HOSPEDE, @ID_FORMA_PAGAMENTO )";
                SqlCommand command = new SqlCommand(sql, con);
                command.Parameters.AddWithValue("@reserva", rBLL.Reserva);
                command.Parameters.AddWithValue("@ID_QUARTO", rBLL.idQuarto);
                command.Parameters.AddWithValue("@ID_FORMA_PAGAMENTO", rBLL.idFormaPagamento);
                command.Parameters.AddWithValue("@ID_HOSPEDE", rBLL._HOSPEDE);
                con.Open();
                int rows = command.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
            }
            finally {
                con.Close();
            }

            return isSuccess;
        }
        public int buscarCodigo(ReservaBLL rBLL)
        {
            con = new SqlConnection(conexao.Conectar());
            try
            {
                string sql = "select count(ID) from tbl_Reserva;";

                SqlCommand comando = new SqlCommand(sql, con);
                con.Open();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    int n = Convert.ToInt32(comando.ExecuteScalar());
                    rBLL.ID = n;
                    
                }
                else
                {
                    int n = Convert.ToInt32(comando.ExecuteScalar());
                    rBLL.ID = n;
                }
            }
            catch (Exception)
            {

            }
            finally { 
                con.Close();
            }
            return rBLL.ID;
        }
    }

}
