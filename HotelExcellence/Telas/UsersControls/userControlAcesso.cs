using Banco;
using HotelExcellence.Telas.acessoNv2.listagem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelExcellence.Telas.Modals
{
    public partial class userControlAcesso : UserControl
    {
        public userControlAcesso()
        {
            InitializeComponent();
        }


        private int id;
        private string nome, email, login, cargo, departamento, senha, nvAcesso;
        private Image foto;

        public int ID 
        {
            get { return id; }
            set { id = value; }
        }
        public string Nome{ get { return nome; } set { nome = value; lblName.Text = value;} }
        public string Email{ get { return email; } set { email = value; lblEmai.Text = "Email: " + value;} }

        public string Login{ get { return login; } set { login = value; lblAcesso.Text = "Login:" + value;} }
        public string Senha{ get { return senha; } set { senha = value; lblSenha.Text = "Senha:" + value;} }
        public string Acesso{ get { return nvAcesso; } set { nvAcesso = value; lblNvAcesso.Text = "Nivel de acesso " + value;} }
        public string Cargo{ get { return cargo; } set { cargo = value; lblCarg.Text = value;} }
        public string Departamento{ get { return departamento; } set { departamento = value; lblDepartament.Text = value;} }
        public Image Foto{ get { return foto; } set { foto = value; bunifuPictureBox2.Image = value;} }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM tbl_Login WHERE ID =" + ID;
            if (MessageBox.Show("Deseja excluir o cadastro", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ServiceDAO sDAO = new ServiceDAO();
                bool sucess = sDAO.Deletando(sql);
                if (sucess)
                {
                    MessageBox.Show("Acesso de funcionario excluido com sucesso!");
                    listAcesso.Instance.acessoPopular("");
                }

            }
        }
    }
}
