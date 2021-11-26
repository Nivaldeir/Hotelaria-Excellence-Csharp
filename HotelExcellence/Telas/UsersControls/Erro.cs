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
    public partial class Erro : Form
    {
        int i = 0;
        public Erro()
        {
            InitializeComponent();
        }
        public Erro(string msg): this()
        {
            try
            {
                lbl.Text = msg.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i <= 99)
            {
                i = i + 5;
            }
        }

        private void Erro_Load(object sender, EventArgs e)
        {
           
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

}
