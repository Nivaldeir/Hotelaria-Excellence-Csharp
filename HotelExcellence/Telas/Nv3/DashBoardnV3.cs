
using HotelExcellence.Telas.cadastros;
using HotelExcellence.Telas.Modals;
using HotelExcellence.Telas.Nv3.listagem;
using System;
using System.Windows.Forms;

namespace HotelExcellence.Telas
{
    public partial class DashBoardnV3 : Form
    {
        MenuCadastrosFRM cadastros = new MenuCadastrosFRM();
        listagemFRM3 listagem = new listagemFRM3();

        public DashBoardnV3()
        {
            InitializeComponent();
            imgBox();
        }

        public void hide()
        {
            cadastros.Hide();
            listagem.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            LoginFRM login = new LoginFRM();
            this.Hide();
            login.Show();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
        }

        public void imgBox()
        {
            imgSlideCad.Visible = false;
            imgSlideLista.Visible = false;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            imgBox();
            logo.Visible = false;
            imgSlideCad.Visible = true;
            Cadastro();
        }

        private void btnListagem_Click(object sender, EventArgs e)
        {
            imgBox();
            logo.Visible = false;
            imgSlideLista.Visible = true;
            Listagem();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("dddd (dd), MMMM (MM) ") + "de " + DateTime.Now.ToString("yyyy HH:mm:ss");
        }
        public void Listagem()
        {
            hide();
            listagem.TopLevel = false;
            listagem.Dock = DockStyle.Fill;
            pnlALL.Controls.Add(listagem);
            listagem.FormBorderStyle = FormBorderStyle.None;
            listagem.Show();
        }
        public void Cadastro()
        {
            hide();
            cadastros.TopLevel = false;
            cadastros.Dock = DockStyle.Fill;
            pnlALL.Controls.Add(cadastros);
            cadastros.FormBorderStyle = FormBorderStyle.None;
            cadastros.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (var sb = new sobre())
            {
                sb.ShowDialog();
            }
        }

        private void DashBoardnV3_Load(object sender, EventArgs e)
        {
            lblUser.Text = informacoesUsuario.funcionarioN;
        }

        private void DashBoardnV3_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
