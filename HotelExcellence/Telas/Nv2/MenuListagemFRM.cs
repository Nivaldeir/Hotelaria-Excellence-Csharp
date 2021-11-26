using HotelExcellence.Telas.acessoNv2.listagem;
using HotelExcellence.Telas.cadastros;
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

namespace HotelExcellence.Telas.Nv2.listagem
{
    public partial class listagemFRM : Form
    {

        quartosFRM quartos = new quartosFRM();
        listFuncionario funcionarios = new listFuncionario();
        estoqueFRM estoque = new estoqueFRM();
        serviceFRM service = new serviceFRM();
        listAcesso login = new listAcesso();

        public listagemFRM()
        {
            InitializeComponent();
        }

        private void btnQuartos_Click(object sender, EventArgs e)
        {
            hide();
            imgStyleQ.Visible = true;
            quartos.TopLevel = false;
            quartos.Dock = DockStyle.Fill;
            pnlALLlistagem.Controls.Add(quartos);
            quartos.FormBorderStyle = FormBorderStyle.None;
            quartos.Show();
            
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            hide();
            imgStyleF.Visible = true;
            funcionarios.TopLevel = false;
            funcionarios.Dock = DockStyle.Fill;
            pnlALLlistagem.Controls.Add(funcionarios);
            funcionarios.FormBorderStyle = FormBorderStyle.None;
            funcionarios.Show();
           
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            hide();
            imgStyleP.Visible = true;
            estoque.TopLevel = false;
            estoque.Dock = DockStyle.Fill;
            pnlALLlistagem.Controls.Add(estoque);
            estoque.FormBorderStyle = FormBorderStyle.None;
            estoque.Show();
           
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            hide();
            imgStyleS.Visible = true;
            service.TopLevel = false;
            service.Dock = DockStyle.Fill;
            pnlALLlistagem.Controls.Add(service);
            service.FormBorderStyle = FormBorderStyle.None;
            service.Show();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            hide();
            imgStyleA.Visible = true;
            funcionarios.Hide();
            login.TopLevel = false;
            login.Dock = DockStyle.Fill;
            pnlALLlistagem.Controls.Add(login);
            login.FormBorderStyle = FormBorderStyle.None;
            login.Show();
        }

        public void hide()
        {
            service.Hide();
            estoque.Hide();
            quartos.Hide();
            funcionarios.Hide();
            login.Hide();
            imgStyleQ.Visible = false;
            imgStyleF.Visible = false;
            imgStyleS.Visible = false;
            imgStyleA.Visible = false;
            imgStyleP.Visible = false;
        }

        private void listagemFRM_Load(object sender, EventArgs e)
        {
            hide();
        }
    }
}
