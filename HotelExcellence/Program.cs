using HotelExcellence.Telas;
using HotelExcellence.Telas.acessoNv1;
using HotelExcellence.Telas.cadastros;
using HotelExcellence.Telas.Nv1;
using HotelExcellence.Telas.Nv2.Cadastros;
using HotelExcellence.Telas.Nv3.Relatorios;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelExcellence
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginFRM());
        }
    }
}
