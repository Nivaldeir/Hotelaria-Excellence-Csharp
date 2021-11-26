
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Classes;

namespace Banco
{
    public class CargosDAO : Geral
    {
        Conexao conexao = new Conexao();
        CargosBLL cBLL;
        SqlConnection con;

        public CargosBLL Pesquisa(string sql)
        {
            cBLL = new CargosBLL();
            con = new SqlConnection(conexao.Conectar());
            try
            {
                SqlCommand comando = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                reader.Read();
                if (!reader.HasRows)
                {
                    //MessageBox.Show("Produto não encontrado");
                }
                else
                {
                    cBLL.Id = int.Parse(reader["ID"].ToString());
                    cBLL.Salario = decimal.Parse(reader["salario"].ToString());
                }
            }
            catch (Exception)
            {

                //MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();
            }
            return cBLL;
        }

        public bool Insert(string sql)
        {
            bool isSucces = false;
            con = new SqlConnection(conexao.Conectar());
            try
            {
                SqlCommand command = new SqlCommand(sql, con);/*
                cmd.Parameters.AddWithValue("@cargo", cBLL.Cargo);
                cmd.Parameters.AddWithValue("@salario", cBLL.Salario);
                cmd.Parameters.AddWithValue("@Carga_horaria", cBLL.CargaHoraria);
                cmd.Parameters.AddWithValue("@n_permissao", cBLL.NivelPermissao);*/
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
                //MessageBox.Show(ex.Message);
            }
            finally {
                con.Close();
            }
            return isSucces;
        }

    }
}
