using Banco;
using Classes;
using HotelExcellence.Telas;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace HotelExcellence
{
    public partial class LoginFRM : Form
    {
        LoginBLL lBLL = new LoginBLL();
        LoginDAO lDAO = new LoginDAO();
        public LoginFRM()
        {
            InitializeComponent();
        }
        private void LoginFRM_Load(object sender, EventArgs e)
        {
            txtLogin.Select();
        }
        private void txtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                txtSenha.Select();
            }
        }
        private void btnAcessar_Click(object sender, EventArgs e)
        {
            string sql = "SELECT L.login, F.ID, F.foto, L.senha, C.n_permissao, F.nome FROM tbl_Login AS L JOIN tbl_Funcionario AS " +
                "F ON F.ID = L.ID_FUNCIONARIO JOIN tbl_Cargos AS C ON C.ID = F.IDcargo WHERE L.login = '" + txtLogin.Text.ToString() + "' " +
                "AND L.senha = '" + txtSenha.Text.ToString() + "' ";

            lBLL = lDAO.Validacao(sql);
            
            if (lBLL._Login == txtLogin.Text || lBLL.Senha == txtSenha.Text)
            {
                informacoesUsuario.funcionarioId = lBLL.Id;
                informacoesUsuario.funcionarioN = lBLL.Nome;
                informacoesUsuario.nPermissao = lBLL.NivelPermissao;
                TelaSlashFRM load = new TelaSlashFRM();
                load.Show();
                this.Hide();
            }
            else
            {
                txtLogin.BorderColorIdle = Color.Red;
                txtSenha.BorderColorIdle = Color.Red;
                txtSenha.Clear();
                MessageBox.Show("Senha ou login incorreto");
            }
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
