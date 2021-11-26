using Banco;
using Classes;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class FuncionarioDAO : Geral
    {
        Conexao conexao = new Conexao();
        SqlConnection con;
        public bool Insert(FuncionarioBLL fBLL)
        {
            con = new SqlConnection(conexao.Conectar());
            bool isSucces = false;
            try
            {
                string sql =
                    "INSERT INTO tbl_Funcionario" +
                    "(nome, cpf, data_nascimento, sexo, cidade, uf, cep, numero, complemento, bairro, " +
                    "naturalidade, celular, telefone, IDcargo, rg, endereco, status, foto) " +
                    "VALUES ('%" + fBLL.Nome +"%', '%"+fBLL.Cpf+"%', '%"+fBLL.dataNascimento+"%', '%"+fBLL.Sexo+"%', '%"+fBLL.Cidade+"%', " +
                    "'%"+fBLL.Uf+"%', '%"+fBLL.Cep+"%', '%"+fBLL.Numero+"%', " +
                    "'%"+fBLL.Complemento+"%', '%"+fBLL.Bairro+"%', '%"+fBLL.Naturalidade+"%'," +
                    " '%"+fBLL.Celular+"%', '%"+fBLL.Telefone+"%'," + fBLL.IDcargo + ", " +
                    "'%"+fBLL.Rg+ "%', '%"+fBLL.Endereco+ "%', '%"+fBLL.Status+ "%', '%"+fBLL.Foto+"%')";
                /* SqlCommand cmd = new SqlCommand(sql, cone);
                 cmd.Parameters.AddWithValue("@nome", fBLL.Nome);
                 cmd.Parameters.AddWithValue("@cpf", fBLL.Cpf);
                 cmd.Parameters.AddWithValue("@data_nascimento", fBLL.dataNascimento);
                 cmd.Parameters.AddWithValue("@sexo", fBLL.Sexo);
                 cmd.Parameters.AddWithValue("@cidade", fBLL.Cidade);
                 cmd.Parameters.AddWithValue("@uf", fBLL.Uf);
                 cmd.Parameters.AddWithValue("@cep", fBLL.Cep );
                 cmd.Parameters.AddWithValue("@numero", fBLL.Numero );
                 cmd.Parameters.AddWithValue("@complemento",fBLL.Complemento );
                 cmd.Parameters.AddWithValue("@bairro", fBLL.Bairro );
                 cmd.Parameters.AddWithValue("@naturalidade", fBLL.Naturalidade);
                 cmd.Parameters.AddWithValue("@celular", fBLL.Celular);
                 cmd.Parameters.AddWithValue("@telefone", fBLL.Telefone);
                 cmd.Parameters.AddWithValue("@rg", fBLL.Rg);
                 cmd.Parameters.AddWithValue("@endereco", fBLL.Endereco);
                 cmd.Parameters.AddWithValue("@status", fBLL.Status);
                 cmd.Parameters.AddWithValue("@foto", fBLL.Foto);
                 cmd.Parameters.AddWithValue("@IDcargo", fBLL.IDcargo);
                 con.Open();*/
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
            finally{ con.Close(); }
            return isSucces;
        } /*ATUALIZANDO OS DADOS DO BANCO DE DADOS DE UM CADASTRO NA TABELA DE FUNCIONARIOS*/
        public FuncionarioBLL Search(string sql)
        {
            FuncionarioBLL fBLL = new FuncionarioBLL();
            try
            {
                SqlCommand command = new SqlCommand(sql, con);
                SqlDataReader reader =command.ExecuteReader();
                reader.Read();
                if (!reader.HasRows)
                {
                    //MessageBox.Show("Produto não encontrado");
                }
                else
                {
                    fBLL.Id = int.Parse(reader["ID"].ToString());
                    fBLL.Nome = reader["nome"].ToString();
                    fBLL.Cpf = reader["cpf"].ToString();
                    fBLL.dataNascimento = DateTime.Parse(reader["data_nascimento"].ToString());
                    fBLL.Sexo = reader["sexo"].ToString();
                    fBLL.Cidade = reader["cidade"].ToString();
                    fBLL.Uf = reader["uf"].ToString();
                    fBLL.Cep = reader["cep"].ToString();
                    fBLL.Numero = reader["numero"].ToString();
                    fBLL.Complemento = reader["complemento"].ToString();
                    fBLL.Bairro = reader["bairro"].ToString();
                    fBLL.Naturalidade = reader["naturalidade"].ToString();
                    fBLL.Celular = reader["celular"].ToString();
                    fBLL.Telefone = reader["telefone"].ToString();
                    fBLL.Rg = reader["rg"].ToString();
                    fBLL.Endereco = reader["endereco"].ToString();
                    fBLL.Status = reader["status"].ToString();
                    fBLL.nomeDepartamento = reader["departamento"].ToString();
                    fBLL.Cargo = reader["cargo"].ToString();
                    fBLL.Foto = (byte[])(reader["foto"]);
                }
            }
            catch (Exception)
            {
            }
            finally { con.Close(); }
            return fBLL;
        } /*BUSCANDO NO BANCO DE DADOS UM CADASTRO E SALVANDO NOS GET E SET DE FUNCIONARIOS*/
        public bool Update(FuncionarioBLL fBLL)
        {
            bool isSucces = false;
            try
            {
                string sql = "UPDATE tbl_Funcionario SET " +
                    "nome = '%"+ fBLL.Nome+"%', " +
                    "cpf = '%"+fBLL.Cpf+"%', " +
                    "data_nascimento = '%"+fBLL.dataNascimento+"%', " +
                    "sexo = '%"+fBLL.Sexo+"%', " +
                    "cidade = '%"+fBLL.Cidade+"%', " +
                    "uf = '%"+fBLL.Uf+"%', " +
                    "cep = '%"+fBLL.Cep+"%', " +
                    "numero = '%"+fBLL.Numero+"%', " +
                    "complemento = '%"+fBLL.Complemento+"%', " +
                    "bairro = '%"+fBLL.Bairro+"%', " +
                    "naturalidade = '%"+fBLL.Naturalidade+"%', " +
                    "celular = '%"+fBLL.Celular+"%', " +
                    "telefone = '%"+fBLL.Telefone+"%', " +
                    "IDcargo = '%"+fBLL.IDcargo+"%', " +
                    "rg = '%"+fBLL.Rg+"%', " +
                    "endereco = '%"+fBLL.Endereco+"%', " +
                    "status = '%"+fBLL.Status+"%', " +
                    "foto = '%"+fBLL.Foto+"%' " +
                    "WHERE ID = '%"+fBLL.Id+"%'";
                /*SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nome", fBLL.nome);
                cmd.Parameters.AddWithValue("@cpf", fBLL.cpf);
                cmd.Parameters.AddWithValue("@data_nascimento", fBLL.data_nascimento);
                cmd.Parameters.AddWithValue("@sexo", fBLL.sexo);
                cmd.Parameters.AddWithValue("@cidade", fBLL.cidade);
                cmd.Parameters.AddWithValue("@uf", fBLL.uf);
                cmd.Parameters.AddWithValue("@cep", fBLL.cep);
                cmd.Parameters.AddWithValue("@numero", fBLL.numero);
                cmd.Parameters.AddWithValue("@complemento", fBLL.complemento);
                cmd.Parameters.AddWithValue("@bairro", fBLL.bairro);
                cmd.Parameters.AddWithValue("@naturalidade", fBLL.naturalidade);
                cmd.Parameters.AddWithValue("@celular", fBLL.celular);
                cmd.Parameters.AddWithValue("@telefone", fBLL.telefone);
                cmd.Parameters.AddWithValue("@rg", fBLL.rg);
                cmd.Parameters.AddWithValue("@endereco", fBLL.endereco);
                cmd.Parameters.AddWithValue("@status", fBLL.status);
                cmd.Parameters.AddWithValue("@IDcargo", fBLL.IDcargo);
                cmd.Parameters.AddWithValue("@foto", fBLL.foto);
                cmd.Parameters.AddWithValue("@ID", fBLL.ID);
                con.Open();*/
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
            catch (Exception){
            }
            finally { 
                con.Close(); 
            }
            return isSucces;
        } /*ATUALIZANDO AS INFORMACOES DE UM CADASTROS NO BANCO DE DADOS*/

    }
}
