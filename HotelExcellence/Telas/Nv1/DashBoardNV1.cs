using HotelExcellence.Telas.acessoNv1;
using HotelExcellence.Telas.Nv1;
using System;
using System.Windows.Forms;

namespace HotelExcellence.Telas
{
    public partial class DashBoardnV1 : Form
    {
        MenuNv1FRM reserva = new MenuNv1FRM();
        CadastrarHospedeFRM hospede = new CadastrarHospedeFRM();
      
        public DashBoardnV1()
        {

            InitializeComponent();
            imgSlideCad.Visible = false;
        }

        private void DashBoardnV1_Load(object sender, EventArgs e)
        {
            lblUser.Text = "Usuario: "+ informacoesUsuario.funcionarioN;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            LoginFRM login = new LoginFRM();

            this.Hide();
            login.Show();
        }
        private void Time_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("dddd (dd), MMMM (MM) ") + "de " + DateTime.Now.ToString("yyyy HH:mm:ss");
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            hide();
            reserva.TopLevel = false;
            reserva.Dock = DockStyle.Fill;
            pnlALL.Controls.Add(reserva);
            reserva.FormBorderStyle = FormBorderStyle.None;
            imgSlideCad.Visible = true;
            reserva.Show();
        }

        public void hide()
        {
            hospede.Hide();
            reserva.Hide();
        }
    }
}
