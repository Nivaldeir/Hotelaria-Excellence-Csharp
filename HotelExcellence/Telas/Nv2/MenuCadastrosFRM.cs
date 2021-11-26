using HotelExcellence.Telas.Nv2.cadastros;
using HotelExcellence.Telas.Nv2.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelExcellence.Telas.cadastros
{
    public partial class MenuCadastrosFRM : Form
    {

        #region INSTANCIAS
        QuartoCadastrosFRM quarto = new QuartoCadastrosFRM();
        FuncionarioCadastrosFRM funcionario = new FuncionarioCadastrosFRM();
        ProdutoCadastrosFRM estoque = new ProdutoCadastrosFRM();
        ServicosCadastrosFRM service = new ServicosCadastrosFRM();
        LoginCadastrosFRM login = new LoginCadastrosFRM();
        #endregion

        public MenuCadastrosFRM()
        {
            InitializeComponent();
            hide();
           quarto.TopLevel = false;
            quarto.Dock = DockStyle.Fill;
            pnlcadALL.Controls.Add(quarto);
            quarto.Show();
            imgStyleQ.Visible = true;
        }

        private void btnQuartos_Click(object sender, EventArgs e)
        {
            hide();
            imgStyleQ.Visible = true;
            quarto.TopLevel = false;
            quarto.Dock = DockStyle.Fill;
            pnlcadALL.Controls.Add(quarto);
            quarto.Show();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            hide();
            imgStyleF.Visible = true;
            funcionario.TopLevel = false;
            funcionario.Dock = DockStyle.Fill;
            pnlcadALL.Controls.Add(funcionario);
            funcionario.Show();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            hide();
            imgStyleP.Visible = true;
            estoque.TopLevel = false;
            estoque.Dock = DockStyle.Fill;
            pnlcadALL.Controls.Add(estoque);
            estoque.Show();
        }

        private void cadastrosFRM_Load(object sender, EventArgs e)
        {
            
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            hide();
            imgStyleS.Visible = true;
            service.TopLevel = false;
            service.Dock = DockStyle.Fill;
            pnlcadALL.Controls.Add(service);
            service.Show();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            hide();
            imgStyleA.Visible = true;
            login.TopLevel = false;
            login.Dock = DockStyle.Fill;
            pnlcadALL.Controls.Add(login);
            login.Show();

        }
        public void hide()
        {
            service.Hide();
            estoque.Hide();
            quarto.Hide();
            funcionario.Hide();
            login.Hide();
            imgStyleQ.Visible = false;
            imgStyleF.Visible = false;
            imgStyleS.Visible = false;
            imgStyleA.Visible = false;
            imgStyleP.Visible = false;
        }
    }
}
