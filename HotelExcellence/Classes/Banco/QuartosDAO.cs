using Banco;
using Classes;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Banco
{
    public class QuartosDAO : Geral
    {
        Conexao conexao = new Conexao();
        SqlConnection con;
        public bool Insert(string sql)
        {
            bool isSucess = false;
            con = new SqlConnection(conexao.Conectar());
            try
            {
                /*string sql = "INSERT INTO tbl_Quarto (nome, descricao, qtd_cama, qtd_banheiro, qtd_tv, preco, numero, foto) Values (@nome, @descricao, @qtd_cama, @qtd_banheiro, @qtd_tv, @preco, @numero, @foto)";
                
                cmd.Parameters.AddWithValue("@nome", qBLL.nome);
                cmd.Parameters.AddWithValue("@descricao", qBLL.descricao);
                cmd.Parameters.AddWithValue("@qtd_cama", qBLL.qtd_cama);
                cmd.Parameters.AddWithValue("@qtd_banheiro", qBLL.qtd_banheiro);
                cmd.Parameters.AddWithValue("@qtd_tv", qBLL.qtd_tv);
                cmd.Parameters.AddWithValue("@preco", qBLL.preco);
                cmd.Parameters.AddWithValue("@numero", qBLL.numero);
                cmd.Parameters.AddWithValue("@foto", qBLL.foto);*/
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
            catch (Exception)
            {
            }
            return isSucess;
        } /*SALVANDO AS INFORMACOES FORA DADO PELO USUARIO E SALVANDO NO BANCO DE DADOS*/
        public bool Update(string  sql)
        {
            bool isSucces = false;
            con = new SqlConnection(conexao.Conectar());
            try
            {
                /*string sql = "UPDATE tbl_Quarto SET nome =@nome, descricao =@descricao, numero =@numero , preco =@preco,  qtd_banheiro =@qtd_banheiro , qtd_cama = @qtd_cama, qtd_tv =@qtd_tv, foto= @foto   WHERE ID = @ID";
                
                cmd.Parameters.AddWithValue("@nome", qBLL.nome);
                cmd.Parameters.AddWithValue("@descricao", qBLL.descricao);
                cmd.Parameters.AddWithValue("@numero", qBLL.numero);
                cmd.Parameters.AddWithValue("@preco", qBLL.preco);
                cmd.Parameters.AddWithValue("@qtd_banheiro", qBLL.qtd_banheiro);
                cmd.Parameters.AddWithValue("@qtd_cama", qBLL.qtd_cama);
                cmd.Parameters.AddWithValue("@qtd_tv", qBLL.qtd_tv);
                cmd.Parameters.AddWithValue("@ID", qBLL.ID);
                cmd.Parameters.AddWithValue("@foto", qBLL.foto);*/
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
            finally
            {
                con.Close();
            }
            return isSucces;
        } /*ATUALIZANDO AS INFORMACOES DE UM CADASTROS NO BANCO DE DADOS*/
        public QuartosBLL Search(string sql)
        {
            QuartosBLL qBLL = new QuartosBLL();
            con = new SqlConnection(conexao.Conectar());
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
                    qBLL.Id = int.Parse(reader["ID"].ToString());
                    qBLL.Nome = reader["nome"].ToString();
                    qBLL.Descricao = reader["descricao"].ToString();
                    qBLL.Numero = reader["numero"].ToString();
                    qBLL.quantidadeCama = int.Parse(reader["qtd_cama"].ToString());
                    qBLL.quantidadeBanheiro = int.Parse(reader["qtd_banheiro"].ToString());
                    qBLL.quantidadeTv = int.Parse(reader["qtd_tv"].ToString());
                    qBLL.Preco = decimal.Parse(reader["preco"].ToString());
                    if ((byte[])(reader["foto"]) == null)
                    {
                        //qBLL.foto = byte[].Parse(ESTOQUEBAIXO);
                    }
                    else
                    {
                        qBLL.Foto = (byte[])(reader["foto"]);
                    }
                }
            }
            catch (Exception)
            {
                // MessageBox.Show(ex.Message
            }
            finally 
            {
                con.Close();
            }
            return qBLL;
        } /*BUSCANDO NO BANCO DE DADOS UM CADASTRO E SALVANDO NOS GET E SET DE QUARTOS*/
    }
}
