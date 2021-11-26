using Guna.UI.WinForms;
using HotelExcellence.Telas.cadastros;
using HotelExcellence.Telas.Modals;
using HotelExcellence.Telas.Nv1;
using HotelExcellence.Telas.Nv2.listagem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelExcellence.Telas
{
    public partial class DashBoardnV2 : Form
    {
        MenuCadastrosFRM cadastros = new MenuCadastrosFRM();
        listagemFRM listagem = new listagemFRM();
        MenuNv1FRM reserva = new MenuNv1FRM();
        public DashBoardnV2()
        {
            InitializeComponent();
            imgBox();
        }


        private void Listagem()
        {
            hide();
            listagem.TopLevel = false;
            listagem.Dock = DockStyle.Fill;
            pnlALL.Controls.Add(listagem);
            listagem.FormBorderStyle = FormBorderStyle.None;
            listagem.Show();

        }

        private void Cadastro()
        {
            hide();
            cadastros.TopLevel = false;
            cadastros.Dock = DockStyle.Fill;
            pnlALL.Controls.Add(cadastros);
            cadastros.FormBorderStyle = FormBorderStyle.None;
            cadastros.Show();
        }
        private void Reserva ()
        {
            hide();
            reserva.TopLevel = false;
            reserva.Dock = DockStyle.Fill;
            pnlALL.Controls.Add(reserva);
            reserva.FormBorderStyle = FormBorderStyle.None;
            reserva.Show();
        }

        private void hide()
        {
            reserva.Hide();
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

        private void Time_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("dddd (dd), MMMM (MM) ") + "de " + DateTime.Now.ToString("yyyy HH:mm:ss");
        }

        private void imgBox()
        {
            imgSlideCad.Visible = false;
            imgSlideLista.Visible = false;
            imgSlideReserva.Visible = false;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            imgBox();
            imgSlideCad.Visible = true;
            Cadastro();
        }

        private void btnListagem_Click(object sender, EventArgs e)
        {
            imgBox();
            imgSlideLista.Visible = true;
            Listagem();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (var sb = new sobre())
            {
                sb.ShowDialog();
            }
        }

        private void DashBoardnV2_Load(object sender, EventArgs e)
        {
            picFuncionario.Image = informacoesUsuario.funcionarioFoto;
            lblUser.Text = "Usuario: " + informacoesUsuario.funcionarioN;
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            imgBox();
            imgSlideReserva.Visible = true;
            Reserva();
        }
    }
}
