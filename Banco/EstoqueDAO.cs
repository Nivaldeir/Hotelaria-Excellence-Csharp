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
               // string sql = "INSERT INTO tbl_Estoque(produto, preco, quantidade) VALUES (@produto, @preco, @quantidade)";
               /*
                cmd.Parameters.AddWithValue("@produto", eBLL.Produto);
                cmd.Parameters.AddWithValue("@preco", eBLL.Preco);
                cmd.Parameters.AddWithValue("@quantidade", eBLL.Quantidade);*/
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

                //essageBox.Show(ex.Message);
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
                //string sql = "SELECT ID, produto, preco, quantidade FROM tbl_Estoque WHERE produto LIKE '%" + produto + "%'";
                SqlCommand command = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (!reader.HasRows)
                {
                    // MessageBox.Show("Produto não encontrado");
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

                //MessageBox.Show(ex.Message);

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
                //string sql = "UPDATE tbl_Estoque SET produto =@produto, quantidade = @quantidade, preco = @preco WHERE ID = @ID";
                /*
                cmd.Parameters.AddWithValue("@produto", eBLL.Produto);
                cmd.Parameters.AddWithValue("@preco", eBLL.Preco);
                cmd.Parameters.AddWithValue("@quantidade", eBLL.Quantidade);
                cmd.Parameters.AddWithValue("@ID", eBLL.Id);*/
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
            finally {
                con.Close();
            }
            return isSucces;
        }
        public EstoqueBLL Search(string sql)
        {
            EstoqueBLL eBLL = new EstoqueBLL();
            try
            {
                SqlCommand command = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (!reader.HasRows)
                {
                    //MessageBox.Show("Produto não encontrado");
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
        //public DataTable Select(string sql)
        //{
        //    DataTable dtEstoque = new DataTable();
        //    try
        //    {
        //        /*SqlCommand cmd = new SqlCommand(sql, con);
        //        con.Open();*/
        //        conexao.Conectando().Open();
        //        SqlDataReader reader = conexao.Executar(sql).ExecuteReader();
        //        dtEstoque.Load(reader);
        //        DataRow row = dtEstoque.NewRow();
        //        row["ID"] = "";
        //        dtEstoque.Rows.InsertAt(row, 0);
        //    }
        //    catch (Exception)
        //    {
        //    }
        //    finally
        //    {
        //        conexao.Conectando().Close();
        //    }
        //    return dtEstoque;
        //}

        //public bool Delete(string sql)
        //{
        //    bool isSucess = false;

        //    try
        //    {

        //        //SqlCommand cmd = new SqlCommand(sql, con);
        //        //cmd.Parameters.AddWithValue("@ID", qBLL.ID);
        //        //con.Open();
        //        int rows = conexao.Executar(sql).ExecuteNonQuery();
        //        if (rows > 0)
        //        {
        //            isSucess = true;
        //        }
        //        else
        //        {
        //            isSucess = false;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //    }
        //    return isSucess;
        //} /*DELETANDO UM CADASTRO ESPECIFICO NO BANCO DE DADOS*/
    }
}
