using Banco;
using HotelExcellence.Telas.acessoNv1.modal;
using HotelExcellence.Telas.Nv1;
using System;
using System.Data;
using System.Windows.Forms;

namespace HotelExcellence.Telas.acessoNv1
{
    
    public partial class ReservarFRM : Form
    {
        ReservaDAO rDAO = new ReservaDAO();

        public ReservarFRM()
        {
            InitializeComponent();
            hide(false);
        }
        public void hide(bool aparecer)
        {
            txtCelular.Visible = aparecer;
            txtCep.Visible = aparecer;
            txtCidade.Visible = aparecer;
            txtComplemento.Visible = aparecer;
            txtDataNascimento.Visible = aparecer;
            txtEndereco.Visible = aparecer;
            txtNaturalidade.Visible = aparecer;
            txtNome.Visible = aparecer;
            txtNumero.Visible = aparecer;
            txtRg.Visible = aparecer;
            txtSexo.Visible = aparecer;
            txtTelefone.Visible = aparecer;
            txtUF.Visible = aparecer;
            btnADD.Visible = aparecer;
            btnADD.Enabled = aparecer;
        }

        public void Pesquisa(string hospede)
        {

            string sql = "SELECT ID, nome, cpf, data_nascimento, sexo, cidade, uf, cep, numero, complemento, " +
                "bairro, naturalidade, celular, telefone, rg, " +
                "endereco FROM tbl_Hospede WHERE cpf = '" + hospede + "' or cnpj = '"+ hospede +"' ";
            DataTable dt = rDAO.BuscandoTudo(sql);
            try
            {
                int i = 0;
                if (dt.Rows[i]["ID"].ToString() != null)
                {
                    txtCelular.Text = dt.Rows[i]["celular"].ToString();
                    txtDataNascimento.Text = dt.Rows[i]["data_nascimento"].ToString();
                    txtCep.Text = dt.Rows[i]["cep"].ToString();
                    txtCidade.Text = dt.Rows[i]["cidade"].ToString();
                    txtComplemento.Text = dt.Rows[i]["complemento"].ToString();
                    txtEndereco.Text = dt.Rows[i]["endereco"].ToString();
                    txtNaturalidade.Text = dt.Rows[i]["naturalidade"].ToString();
                    txtNome.Text = dt.Rows[i]["nome"].ToString();
                    txtNumero.Text = dt.Rows[i]["numero"].ToString();
                    txtRg.Text = dt.Rows[i]["rg"].ToString();
                    txtSexo.Text = dt.Rows[i]["sexo"].ToString();
                    txtTelefone.Text = dt.Rows[i]["telefone"].ToString();
                    txtUF.Text = dt.Rows[i]["uf"].ToString();
                    informacoesUsuario.idHospede = int.Parse(dt.Rows[i]["ID"].ToString());
                    hide(true);
                }
            }
            catch (Exception)
            {
                hide(false);
                MessageBox.Show("Hospede não encontrado");
            }
        }
        private void txtCpfPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Pesquisa(txtCpfPesquisa.Text);
            }
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            using (var progresso = new AgendaReservaFRM())
            {
                progresso.ShowDialog();
                hide(false);
                txtCpfPesquisa.Clear();
                txtCpfPesquisa.Focus();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            using (var cad = new CadastrarModalFRM())
            {
                cad.ShowDialog();
            }
        }
    }
}
