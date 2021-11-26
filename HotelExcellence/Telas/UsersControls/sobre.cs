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
    public partial class sobre : Form
    {
        public sobre()
        {
            InitializeComponent();
            label1.MaximumSize = new Size(375,243);
            label1.Text = "A Excellencia Hotel (empresa fictícia) fundada em 1982 com o intuito de atender com qualidade e eficiência no ramo de hotel / pousada, com o tempo passando a empresa começou a ter um marco.No decorrer desses anos tornou - se líder em sua cidade. Com o crescimento de sua empresa e com nova administração gerencial, foi proposto uma reestruturação na infraestrutura de tecnologia.";
        }
    }
}
