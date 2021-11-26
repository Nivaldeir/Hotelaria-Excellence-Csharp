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
                /*string sql = "INSERT INTO tbl_Departamento(nome) VALUES (@nome)";
                
                cmd.Parameters.AddWithValue("@nome", dBLL.Nome);*/
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

                //MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
            return isSucces;
        }
        public bool Update(string sql)
        {
            bool isSucces = false;
            try
            {
                /*string sql = "UPDATE tbl_Departamento SET nome =@nome  WHERE id = @ID";
                
                cmd.Parameters.AddWithValue("@nome", dBLL.Nome);
                cmd.Parameters.AddWithValue("@id", dBLL.Id);*/
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

                //MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
            return isSucces;
        }
        //public DataTable Select()
        //{
        //    DataTable dt = new DataTable();
          
        //    try
        //    {
        //        SqlConnection con = new SqlConnection(conexao.Conectar());
        //        string sql = "SELECT * FROM tbl_Departamento";
        //        SqlCommand cmd = new SqlCommand(sql, con);
        //        con.Open();

        //        SqlDataReader reader = cmd.ExecuteReader();//conexao.Executar(sql).ExecuteReader();
        //        dt.Load(reader);
        //        DataRow row = dt.NewRow();
        //        row["ID"] = "";
        //        dt.Rows.InsertAt(row, 0);
        //    }
        //    catch (Exception)
        //    {
        //    }
        //    return dt;
        //}
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

                //MessageBox.Show(ex.Message);

            }
            finally {
                con.Close();
            }
            return dBLL;
        }
    }
}
