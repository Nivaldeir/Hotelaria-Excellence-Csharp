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

namespace HotelExcellence.Telas.Nv3.listagem
{
    public partial class listagemFRM3 : Form
    {
        quartosFRM quartos = new quartosFRM();
        listFuncionario funcionarios = new listFuncionario();
        estoqueFRM estoque = new estoqueFRM();
        serviceFRM service = new serviceFRM();
        listCargoFRM3 cargo = new listCargoFRM3();
        listDepartamentoFRM3 departamento = new listDepartamentoFRM3();
        public listagemFRM3()
        {
            InitializeComponent();
            quartos.TopLevel = false;
            quartos.Dock = DockStyle.Fill;
            pnlALLlistagem.Controls.Add(quartos);
            quartos.FormBorderStyle = FormBorderStyle.None;
            quartos.Show();
        }

        private void btnQuartos_Click(object sender, EventArgs e)
        {
            hide();
            quartos.TopLevel = false;
            quartos.Dock = DockStyle.Fill;
            pnlALLlistagem.Controls.Add(quartos);
            quartos.FormBorderStyle = FormBorderStyle.None;
            quartos.Show();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            hide();
            funcionarios.TopLevel = false;
            funcionarios.Dock = DockStyle.Fill;
            pnlALLlistagem.Controls.Add(funcionarios);
            funcionarios.FormBorderStyle = FormBorderStyle.None;
            funcionarios.Show();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            hide();
            estoque.TopLevel = false;
            estoque.Dock = DockStyle.Fill;
            pnlALLlistagem.Controls.Add(estoque);
            estoque.FormBorderStyle = FormBorderStyle.None;
            estoque.Show();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            hide();
            service.TopLevel = false;
            service.Dock = DockStyle.Fill;
            pnlALLlistagem.Controls.Add(service);
            service.FormBorderStyle = FormBorderStyle.None;
            service.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //hide();
            //login.TopLevel = false;
            //login.Dock = DockStyle.Fill;
            //pnlALLlistagem.Controls.Add(login);
            //login.FormBorderStyle = FormBorderStyle.None;
            //login.Show();
        }

        private void btnCargo_Click(object sender, EventArgs e)
        {
            hide();
            cargo.TopLevel = false;
            cargo.Dock = DockStyle.Fill;
            pnlALLlistagem.Controls.Add(cargo);
            cargo.FormBorderStyle = FormBorderStyle.None;
            cargo.Show();
        }

        private void btnDepartamento_Click(object sender, EventArgs e)
        {
            hide();
            departamento.TopLevel = false;
            departamento.Dock = DockStyle.Fill;
            pnlALLlistagem.Controls.Add(departamento);
            departamento.FormBorderStyle = FormBorderStyle.None;
            departamento.Show();
        }

        public void hide()
        {
            cargo.Hide();
            service.Hide();
            estoque.Hide();
            quartos.Hide();
            funcionarios.Hide();
            departamento.Hide();
            cargo.Hide();
            //login.Hide();
        }
    }
}
