using Util;
using System;
using Classes;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Banco
{
    public class LoginDAO : Geral
    {
        Conexao conexao = new Conexao();
        SqlConnection con;
        public FuncionarioBLL Pesquisa(string sql)
        {
            FuncionarioBLL fBLL = new FuncionarioBLL();
            con = new SqlConnection(conexao.Conectar());
            try
            {
                SqlCommand command = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (!reader.HasRows)
                {
                }
                else
                {
                    fBLL.Id = int.Parse(reader["ID"].ToString());
                    fBLL.Nome = reader["nome"].ToString();
                    fBLL.dataNascimento = DateTime.Parse(reader["data_nascimento"].ToString());
                    fBLL.Rg = reader["rg"].ToString();
                    fBLL.Endereco = reader["endereco"].ToString();
                    fBLL.Bairro = reader["bairro"].ToString();
                    fBLL.Cep = reader["cep"].ToString();
                    fBLL.Celular = reader["celular"].ToString();
                    fBLL.Cargo = reader["cargo"].ToString();
                    fBLL.nomeDepartamento = reader["Departamento"].ToString();
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                con.Close();
            }
            return fBLL;
        }
        public bool Insert(string sql)
        {
            bool isSucces = false;
            con = new SqlConnection(conexao.Conectar());
            try
            {
                /*
                cmd.Parameters.AddWithValue("@email", lBLL.email);
                cmd.Parameters.AddWithValue("@login", lBLL.login);
                cmd.Parameters.AddWithValue("@senha", lBLL.senha);*/
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
        public bool Update(string sql)
        {
            bool isSucces = false;
            con = new SqlConnection(conexao.Conectar());
            try
            {

                /*
                cmd.Parameters.AddWithValue("@email", lBLL.email);
                cmd.Parameters.AddWithValue("@login",lBLL.login);
                cmd.Parameters.AddWithValue("@senha", lBLL.senha);
                cmd.Parameters.AddWithValue("@ID", lBLL.ID);*/
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
            catch (Exception )
            {
            }
            finally
            {
                con.Close();
            }
            return isSucces;
        }
        public LoginBLL Search(string sql)
        {
            LoginBLL lBLL = new LoginBLL();
            con = new SqlConnection(conexao.Conectar());

            try
            {
                SqlCommand command = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    lBLL.Email = reader["email"].ToString();
                    lBLL._Login = reader["login"].ToString();
                    lBLL.Senha = reader["senha"].ToString();
                }
            }
            catch (Exception)
            {
            }
            return lBLL;
        }
        public LoginBLL Validacao(string sql)
        {
            LoginBLL lBLL = new LoginBLL();
            con = new SqlConnection(conexao.Conectar());
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand(sql, con);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (!reader.HasRows)
                {
                    //MessageBox.Show("Produto não encontrado");
                }
                else
                {

                    lBLL.Senha = reader["senha"].ToString();
                    lBLL.Usuario = int.Parse(reader["ID"].ToString());
                    lBLL._Login = reader["login"].ToString();
                    lBLL.Nome = reader["nome"].ToString();
                    lBLL.NivelPermissao = int.Parse(reader["n_permissao"].ToString());
                    lBLL.Foto = (byte[])(reader["foto"]);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                con.Close();
            }
            return lBLL;
        }
    }
}
