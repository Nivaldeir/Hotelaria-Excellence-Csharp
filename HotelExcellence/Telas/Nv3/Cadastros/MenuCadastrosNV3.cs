using HotelExcellence.Telas.cadastros;
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

namespace HotelExcellence.Telas.Nv3.cadastros
{

    public partial class MenuCadastroNV3 : Form
    {
        #region INSTANCIAS

        QuartoCadastrosFRM quarto = new QuartoCadastrosFRM();
        FuncionarioCadastrosFRM funcionario = new FuncionarioCadastrosFRM();
        ProdutoCadastrosFRM estoque = new ProdutoCadastrosFRM();
        ServicosCadastrosFRM service = new ServicosCadastrosFRM();
        cadDepartamentoFRM3 departamento = new cadDepartamentoFRM3();
        cadCargoFRM3 cargo = new cadCargoFRM3();
        LoginCadastrosFRM login = new LoginCadastrosFRM();
        #endregion


        public MenuCadastroNV3()
        {
            InitializeComponent();
        }

        private void btnQuartos_Click(object sender, EventArgs e)
        {
            hide();
            quarto.TopLevel = false;
            quarto.Dock = DockStyle.Fill;
            pnlcadALL.Controls.Add(quarto);
            quarto.Show();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            hide();
            funcionario.TopLevel = false;
            funcionario.Dock = DockStyle.Fill;
            pnlcadALL.Controls.Add(funcionario);
            funcionario.Show();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            hide();
            estoque.TopLevel = false;
            estoque.Dock = DockStyle.Fill;
            pnlcadALL.Controls.Add(estoque);
            estoque.Refresh();
            estoque.Show();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            hide();
            service.TopLevel = false;
            service.Dock = DockStyle.Fill;
            pnlcadALL.Controls.Add(service);
            service.Show();
        }

        private void btnDepartamento_Click(object sender, EventArgs e)
        {
            hide();
            departamento.TopLevel = false;
            departamento.Dock = DockStyle.Fill;
            pnlcadALL.Controls.Add(departamento);
            departamento.Show();
        }

        private void btnCargo_Click(object sender, EventArgs e)
        {
            hide();
            cargo.TopLevel = false;
            cargo.Dock = DockStyle.Fill;
            pnlcadALL.Controls.Add(cargo);
            cargo.Show();
            
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            hide();
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
            departamento.Hide();
            cargo.Hide();
            login.Hide();
        }
    }
}
