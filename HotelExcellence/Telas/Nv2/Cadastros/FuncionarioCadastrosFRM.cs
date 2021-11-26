using Banco;
using Classes;
using Correios;
using HotelExcellence.Telas.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;

namespace HotelExcellence.Telas.Nv2.Cadastros
{
    public partial class FuncionarioCadastrosFRM : Form
    {

        #region INSTANCIAS
        CargosDAO cDAO = new CargosDAO();
        FuncionarioDAO fDAO = new FuncionarioDAO();
        DepartamentoDAO dDAO = new DepartamentoDAO();
        Utils util = new Utils();
        DepartamentoBLL dBLL = new DepartamentoBLL();
        CargosBLL cBLL = new CargosBLL();
        FuncionarioBLL fBLL = new FuncionarioBLL();
        #endregion

        #region Variaveis
        bool verificado = false;
        Bitmap bmp;

        #endregion
        public FuncionarioCadastrosFRM()
        {
            InitializeComponent();

            string sql = "SELECT * FROM tbl_departamento";
            DataTable dtDepartamento = dDAO.BuscandoTudo(sql);
            cbDepartamento.DataSource = dtDepartamento;
            cbDepartamento.DisplayMember = "id";
            cbDepartamento.DisplayMember = "nome";
            txtNomeFuncionario.Focus();

        }

        private void txtCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscandoCep();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cadastrar();
        }

        private bool Verificacao()
        {

            if (txtNomeFuncionario.Text == "" || txtCelular.Text == "" || txtCPF.Text == "" || txtRG.Text == "" || txtCEP.Text == "" || cbProfissao.Text == "" || cbSEXO.Text == "" || txtBairro.Text == "")
            {
                if (txtNomeFuncionario.Text == "")
                {
                    this.txtNomeFuncionario.BorderColorIdle = Color.Red;
                    this.lnlNome.ForeColor = Color.Red;
                }

                if (txtCelular.Text == "")
                {
                    this.txtCelular.BorderColorIdle = Color.Red;
                    this.lblCelular.ForeColor = Color.Red;
                }
                if (txtCPF.Text == "")
                {
                    this.txtCPF.BorderColorIdle = Color.Red;
                    this.lblCPF.ForeColor = Color.Red;
                }
                if (txtRG.Text == "")
                {
                    this.txtRG.BorderColorIdle = Color.Red;
                    this.lblRG.ForeColor = Color.Red;
                }

                if (txtCEP.Text == "")
                {
                    this.txtCEP.BorderColorIdle = Color.Red;
                    this.lblCEP.ForeColor = Color.Red;
                }
                if (txtBairro.Text == "")
                {
                    this.txtBairro.BorderColorIdle = Color.Red;
                }
                if (txtNumero.Text == "")
                {
                    this.txtNumero.BorderColorIdle = Color.Red;
                    this.lblNumero.ForeColor = Color.Red;
                }

                if (cbProfissao.Text == "")
                {
                    this.cbProfissao.BorderColor = Color.Red;
                    this.lblProfissao.ForeColor = Color.Red;
                }

                if (cbSEXO.Text == "")
                {
                    this.cbSEXO.BorderColor = Color.Red;
                    this.lblSexo.ForeColor = Color.Red;
                }
            }
            else
            {
                verificado = true;
            }

            return verificado;
        } /*VERIFICANDO SE TODOS OS CAMPOS OBRIGATORIOS(*) FORAM PREENCHIDOS*/

        private void Clear()
        {
            txtCelular.Clear();
            txtCargarHoraria.Clear();
            txtBairro.Clear();
            txtCPF.Clear();
            txtEndereco.Clear();
            txtNaturalidade.Clear();
            txtNomeFuncionario.Clear();
            txtNumero.Clear();
            txtRG.Clear();
            txtSalario.Clear();
            txtTelefone.Clear();
            txtUF.Clear();
            txtCEP.Clear();
            txtNomeFuncionario.Focus();

        } /*FUNCAO PARA LIMPAR TODOS OS CAMPOS*/

        private void cbDepartamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    txtSalario.DataBindings.Clear();
                    txtCargarHoraria.DataBindings.Clear();

                    string idDepartamento = cbDepartamento.Text.ToString();
                    string sql = "SELECT id, nome FROM tbl_Departamento WHERE nome = '" + idDepartamento + "'  ";
                    dBLL = dDAO.Pesquisa(sql);
                    sql = "SELECT cargo, salario, Carga_horaria FROM tbl_Cargos WHERE n_permissao <=" + 3 + " AND ID_Departamento =" + dBLL.Id;

                    DataTable dtCargo = cDAO.BuscandoTudo(sql);
                    cbProfissao.DataSource = dtCargo;

                    cbProfissao.DisplayMember = "cargo";
                    txtSalario.DataBindings.Add("text", dtCargo, "salario");
                    txtCargarHoraria.DataBindings.Add("text", dtCargo, "carga_horaria");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Cadastrar()
        {
            Verificacao();
            if (verificado == true)
            {
                bool cpf = util.validacaoCPF(txtCPF.Text);
                if (cpf == false)
                {
                    MessageBox.Show("Cpf invalido");
                }
                else
                {
                    #region fBLLs
                    fBLL.Nome = txtNomeFuncionario.Text.ToString();
                    fBLL.Cpf = txtCPF.Text.ToString();
                    fBLL.dataNascimento = dtDate.Value.Date;
                    fBLL.Sexo = cbSEXO.Text.ToString();
                    fBLL.Cidade = txtCidade.Text.ToString();
                    fBLL.Uf = txtUF.Text.ToString();
                    fBLL.Cep = txtCEP.Text.ToString();
                    fBLL.Numero = txtNumero.Text.ToString();
                    fBLL.Complemento = txtComplemento.Text.ToString();
                    fBLL.Bairro = txtBairro.Text.ToString();
                    fBLL.Naturalidade = txtNaturalidade.Text.ToString();
                    fBLL.Celular = txtCelular.Text.ToString();
                    fBLL.Telefone = txtTelefone.Text.ToString();
                    fBLL.Rg = txtRG.Text.ToString();
                    fBLL.Endereco = txtEndereco.Text.ToString();
                    fBLL.Status = "Ativo";

                    /* CONVERTENDO EM BYTES*/
                    MemoryStream memory = new MemoryStream();
                    bmp.Save(memory, ImageFormat.Bmp);
                    fBLL.Foto = memory.ToArray();

                    cBLL = cDAO.Pesquisa("SELECT ID, salario FROM tbl_Cargos WHERE cargo LIKE '%" + cbProfissao.Text + "%'");
                    fBLL.Cargo = cBLL.Id.ToString();

                    #endregion
                    bool sucess = fDAO.Insert(fBLL);
                    if (sucess == true)
                    {
                        string msg = "Cadastrado com sucesso";
                        using (var Add = new Adicionado(msg))
                        {
                            Add.ShowDialog();
                        }
                        //MessageBox.Show("Cadastrado com sucesso", "", MessageBoxButtons.OK);
                        Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos com *", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        } /*FUNCAO PARA CADASTRAR O FUNCIONARIO CUJO AS INFORMACOES FORAM PREENCHIDAS NOS CAMPOS OBRIGATORIOS*/
        private void btnADD_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG Files(*.jpg)|*jpg|PNG Files(*png)|*.png |ALLFiles(*.*)| *.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foto = dialog.FileName;
                bmp = new Bitmap(foto);
                picFuncionario.Image = bmp;
            }
        } // ADICIONANDO IMAGEM NO PICTURE POX

        private void buscandoCep()
        {
            if (!string.IsNullOrEmpty(txtCEP.Text))
            {
                CorreiosApi correios = new CorreiosApi();
                var retorno = correios.consultaCEP(txtCEP.Text);
                txtBairro.Text = retorno.bairro;
                txtCidade.Text = retorno.cidade;
                txtEndereco.Text = retorno.end;
                txtUF.Text = retorno.uf;
                cbProfissao.Focus();
            }
            else
            {
                MessageBox.Show("Cep não encontrando");
            }
        }
    }
}
