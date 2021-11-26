using Banco;
using Classes;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelExcellence.Telas.Nv2.listagem.Modals
{
    public partial class editeLoginFRM : Form
    {
        LoginBLL lBLL = new LoginBLL();
        LoginDAO lDAO = new LoginDAO();
        int IDD;
        public editeLoginFRM()
        {
            InitializeComponent();
        }

        public editeLoginFRM(int ID): this()
        {
            this.txtEmail.Select();
            try
            {
                IDD = ID;
                string sql = "SELECT email, login, senha FROM tbl_Login WHERE ID LIKE '%" + ID + "%'";
                lBLL = lDAO.Search(sql);
                txtEmail.Text = lBLL.Email;
                txtLogin.Text = lBLL._Login;
                txtSenha.Text = lBLL.Senha;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool verificado = Verificacao();
            if (verificado == true)
            {
                /*lBLL.email = txtEmail.Text.ToString();
                lBLL.login = txtLogin.Text.ToString();
                lBLL.senha = txtSenha.Text.ToString();
                lBLL.ID = IDD;*/

                string sql = "UPDATE tbl_Login SET " +
                    "email ='%"+ txtEmail.Text.ToString() + "%', " +
                    "login ='%" + txtLogin.Text.ToString() + "%', " +
                    "senha = '%" + txtSenha.Text.ToString() + "%'  " +
                    "WHERE ID = '%" +IDD +"%'";


                bool sucess = lDAO.Update(sql);
                if (sucess == true)
                {
                    MessageBox.Show("Atualização feita com sucesso");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar","", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Verifique se todas as informações foram preenchidas corretamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

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
