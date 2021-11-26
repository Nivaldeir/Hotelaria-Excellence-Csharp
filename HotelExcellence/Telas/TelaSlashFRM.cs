using System;
using System.Windows.Forms;
namespace HotelExcellence.Telas
{
    public partial class TelaSlashFRM : Form
    {
        public TelaSlashFRM()
        {
            InitializeComponent();
            gunaProgressBar1.Maximum = 100;
            timer1.Start();
            lblUser.Text = "Bem Vindo " + informacoesUsuario.funcionarioN;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (gunaProgressBar1.Value < 100)
            {gunaProgressBar1.Value = gunaProgressBar1.Value + 2;
            }
            else
            {
                timer1.Stop();
                if (gunaProgressBar1.Value == 100)
                {
                    switch (informacoesUsuario.nPermissao)
                    {
                        case 1:
                            DashBoardnV1 frm1 = new DashBoardnV1();
                            frm1.Show();
                            this.Hide();
                            break;
                        case 2:
                            DashBoardnV2 frm2 = new DashBoardnV2();
                            frm2.Show();
                            this.Hide();
                            break;

                        case 3:
                            DashBoardnV3 frm3 = new DashBoardnV3();
                            frm3.Show();
                            this.Hide();
                            break;
                        default:
                            MessageBox.Show("Usuario sem acesso");
                            break;
                    }
                }
            }
        }
    }
}
