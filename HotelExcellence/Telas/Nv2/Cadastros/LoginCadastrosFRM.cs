using Classes;
using Banco;
using HotelExcellence.Telas.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelExcellence.Telas.Nv2.cadastros
{
    public partial class LoginCadastrosFRM : Form
    {
        FuncionarioBLL fBLL = new FuncionarioBLL();
        DepartamentoBLL dBLL = new DepartamentoBLL();
        CargosBLL cBLL = new CargosBLL();
        LoginDAO lDAO = new LoginDAO();
        LoginBLL lBLL = new LoginBLL();

        int ID = 0;

        public LoginCadastrosFRM()
        {
            InitializeComponent();
            lblNome.Text = "Nome: ";
            lblBairro.Text = "Bairro: ";
            lblCargo.Text = "Cargo: ";
            lblCelular.Text = "Celular: ";
            lblCep.Text = "Cep: ";
            lblDepartamento.Text = "Departamento: ";
            lblRG.Text = "RG: ";
            lblEndereco.Text = "Endereço: ";
            lblDate.Text = "Nascido em: ";
        }

        private void txtCPF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string sql = "SELECT F.ID, F.nome, f.rg, f.data_nascimento, f.celular, f.cep, f.bairro, f.endereco,  C.cargo, D.nome AS Departamento FROM tbl_Funcionario AS F JOIN tbl_Cargos AS C ON C.ID = F.IDcargo  JOIN tbl_Departamento AS D ON D.id = C.ID_Departamento WHERE f.cpf ='" + txtCPF.Text.ToString() + "'";
                fBLL = lDAO.Pesquisa(sql);
                try
                {
                    ID = fBLL.Id;
                    if (ID != 0)
                    {
                        
                        lblNome.Text = "Nome: " + fBLL.Nome.ToString();
                        lblBairro.Text = "Bairro: " + fBLL.Bairro.ToString();
                        lblCargo.Text = "Cargo: " + fBLL.Cargo.ToString();
                        lblCelular.Text = "Celular: " + fBLL.Celular.ToString();
                        lblCep.Text = "Cep: " + fBLL.Cep.ToString();
                        lblDepartamento.Text = "Departamento: " + fBLL.nomeDepartamento.ToString();
                        lblRG.Text = "RG: " + fBLL.Rg.ToString();
                        lblDate.Text = "Nascido em: " + fBLL.dataNascimento.ToString("MM/dd/yyyy");
                        lblEndereco.Text = "Endereço: " + fBLL.Endereco.ToString() ;
                        txtEmail.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Funcionario não encontrado em nosso banco de dados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                   

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
           /* lBLL._Login = txtLogin.Text.ToString();
            lBLL.Email = txtEmail.Text.ToString();
            lBLL.Senha = txtSenha.Text.ToString();
            lBLL.Usuario = ID;*/

            bool verificado = Verificacao();
            if (ID != 0)
            {
                if (verificado == true)
                {
                    string sql = "INSERT INTO tbl_Login(email, login, senha, ID_FUNCIONARIO) VALUES ('%" + txtEmail.Text.ToString() + "%', '%" + txtLogin.Text.ToString() + "%', '%" + txtSenha.Text.ToString() +"%', " + ID + " )";
                    bool sucess = lDAO.Insert(sql);
                    if (sucess == true)
                    {
                        string msg = "Acesso cadastrado com sucesso!";
                        using (var Add = new Adicionado(msg))
                        {
                            Add.ShowDialog();
                        }
                        //MessageBox.Show(", "", MessageBoxButtons.OK);
                        Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Chame um tecnico, ERRO: L-A", "", MessageBoxButtons.OK);
                }
            }
            else
            {
                string msg = "Funcionario já existe um aceso registrado";
                using (var erro = new Erro(msg))
                {
                    erro.ShowDialog();
                }
                //MessageBox.Show("Funcionario já existe um aceso registrado!  \n Chame um administrador \n ERRO: A-R", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        public void Clear()
        {
            lblNome.Text = "Nome: ";
            lblBairro.Text = "Bairro: ";
            lblCargo.Text = "Cargo: " ;
            lblCelular.Text = "Celular: " ;
            lblCep.Text = "Cep: " ;
            lblDepartamento.Text = "Departamento: " ;
            lblRG.Text = "RG: " ;
            lblDate.Text = "Nascido em: ";
            lblEndereco.Text = "Endereço: ";
            txtSenha.Clear();
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void cadLoginFRM_Load(object sender, EventArgs e)
        {

        }

        public bool Verificacao()
        {
            bool verificado = false; 
            if (txtEmail.Text == "" || txtLogin.Text == "" || txtSenha.Text =="")
            {
                if (txtEmail.Text == "")
                {
                    this.txtEmail.BorderColorIdle = Color.Red;
                }
                if (txtLogin.Text == "")
                {
                    this.txtLogin.BorderColorIdle = Color.Red;
                }
                if (txtSenha.Text == "")
                {
                    this.txtSenha.BorderColorIdle = Color.Red;
                }
                verificado = false;
            }
            else
            {
                verificado = true;
            }
            return verificado;
        }
    }
}
