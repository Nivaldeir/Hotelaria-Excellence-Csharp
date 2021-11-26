
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace Banco
{
    public class HospedeDAO : Geral
    {
        Conexao conexao = new Conexao();
        SqlConnection con;
        /*ATUALIZANDO OS DADOS DO BANCO DE DADOS DE UM CADASTRO NA TABELA DE HOSPEDEs*/
        public bool cadastrandoHospedeFisico(HospedeFisicoBLL hBLL)
        {
            bool isSucces = false;
            con = new SqlConnection(conexao.Conectar());
            try
            {
                string sql = "INSERT INTO tbl_Hospede(nome, cpf, data_nascimento, sexo, cidade, uf, cep, numero, complemento, bairro, naturalidade, celular, telefone, rg, endereco) VALUES (@nome, @cpf, @data_nascimento, @sexo, @cidade, @uf, @cep, @numero, @complemento, @bairro, @naturalidade, @celular, @telefone, @rg, @endereco)";
                SqlCommand command = new SqlCommand(sql, con);

                command.Parameters.AddWithValue("@nome", hBLL.Nome);
                command.Parameters.AddWithValue("@cpf", hBLL.Cpf);
                command.Parameters.AddWithValue("@data_nascimento", hBLL.dataNascimento);
                command.Parameters.AddWithValue("@sexo", hBLL.Sexo);
                command.Parameters.AddWithValue("@cidade", hBLL.Cidade);
                command.Parameters.AddWithValue("@uf", hBLL.Uf);
                command.Parameters.AddWithValue("@cep", hBLL.Cep);
                command.Parameters.AddWithValue("@numero", hBLL.Numero);
                command.Parameters.AddWithValue("@complemento", hBLL.Complemento);
                command.Parameters.AddWithValue("@bairro", hBLL.Bairro);
                command.Parameters.AddWithValue("@naturalidade", hBLL.Naturalidade);
                command.Parameters.AddWithValue("@celular", hBLL.Celular);
                command.Parameters.AddWithValue("@telefone", hBLL.Telefone);
                command.Parameters.AddWithValue("@rg", hBLL.Rg);
                command.Parameters.AddWithValue("@endereco", hBLL.Endereco);
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
        public bool cadastrandoHospedeCnpj(HospedeFisicoBLL hBLL)
        {
            bool isSucces = false;
            con = new SqlConnection(conexao.Conectar());
            try
            {
                string sql = "INSERT INTO tbl_Hospede(nome, cnpj, data_nascimento, sexo, cidade, uf, cep, numero, complemento, bairro, naturalidade, celular, telefone, rg, endereco, razaoSocial) VALUES (@nome, @cnpj, @data_nascimento, @sexo, @cidade, @uf, @cep, @numero, @complemento, @bairro, @naturalidade, @celular, @telefone, @rg, @endereco, @razaoSocial)";
                SqlCommand command = new SqlCommand(sql, con);
                command.Parameters.AddWithValue("@nome", hBLL.Nome);
                command.Parameters.AddWithValue("@cnpj", hBLL.Cpnj);
                command.Parameters.AddWithValue("@razaoSocial", hBLL.razaoSocial);
                command.Parameters.AddWithValue("@data_nascimento", hBLL.dataNascimento);
                command.Parameters.AddWithValue("@sexo", hBLL.Sexo);
                command.Parameters.AddWithValue("@cidade", hBLL.Cidade);
                command.Parameters.AddWithValue("@uf", hBLL.Uf);
                command.Parameters.AddWithValue("@cep", hBLL.Cep);
                command.Parameters.AddWithValue("@numero", hBLL.Numero);
                command.Parameters.AddWithValue("@complemento", hBLL.Complemento);
                command.Parameters.AddWithValue("@bairro", hBLL.Bairro);
                command.Parameters.AddWithValue("@naturalidade", hBLL.Naturalidade);
                command.Parameters.AddWithValue("@celular", hBLL.Celular);
                command.Parameters.AddWithValue("@telefone", hBLL.Telefone);
                command.Parameters.AddWithValue("@rg", hBLL.Rg);
                command.Parameters.AddWithValue("@endereco", hBLL.Endereco);
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
    }
}
