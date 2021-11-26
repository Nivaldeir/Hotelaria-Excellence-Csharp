using HotelExcellence.Telas.acessoNv1;
using HotelExcellence.Telas.Nv1.Reserva;
using System;
using System.Windows.Forms;

namespace HotelExcellence.Telas.Nv1
{
    public partial class MenuNv1FRM : Form
    {
        #region INSTANCIA
        ReservarFRM reserva = new ReservarFRM();
        CadastrarHospedeFRM hospede = new CadastrarHospedeFRM();
        BuscaReservaFRM consulta = new BuscaReservaFRM();
        #endregion
        public MenuNv1FRM()
        {
            InitializeComponent();
            hide();
        }

        private void pnlCadastros_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            hide();
            imgStyleR.Visible = true;
            reserva.TopLevel = false;
            reserva.Dock = DockStyle.Fill;
            pnlcadALL.Controls.Add(reserva);
            reserva.Show();
        }
        public void hide()
        {
            consulta.Hide();
            reserva.Hide();
            hospede.Hide();
            imgStyleR.Visible = false;
            imgStyleC.Visible = false;
            imgStyleH.Visible = false;
        }

        private void btnCadastroHospede_Click(object sender, EventArgs e)
        {
            hide();
            hospede.TopLevel = false;
            hospede.Dock = DockStyle.Fill;
            pnlcadALL.Controls.Add(hospede);
            hospede.FormBorderStyle = FormBorderStyle.None;
            imgStyleH.Visible = true;
            hospede.Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            hide();
            consulta.TopLevel = false;
            consulta.Dock = DockStyle.Fill;
            pnlcadALL.Controls.Add(consulta);
            consulta.FormBorderStyle = FormBorderStyle.None;
            imgStyleC.Visible = true;
            BuscaReservaFRM.Instance.Selecionado();
            consulta.Show();
            

        }
    }
}
