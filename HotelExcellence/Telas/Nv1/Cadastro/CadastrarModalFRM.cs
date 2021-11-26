using Banco;
using Classes;
using Correios;

using HotelExcellence.Telas.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;

namespace HotelExcellence.Telas.acessoNv1.modal
{
    public partial class CadastrarModalFRM : Form
    {
        #region INSTANCIA
        HospedeFisicoBLL hBLL = new HospedeFisicoBLL();
        HospedeDAO hDAO = new HospedeDAO();
        Utils util = new Utils();
        #endregion
        public CadastrarModalFRM()
        {
            InitializeComponent();
        }

        #region FUNCTION
        /*VERIFICANDO SE TODOS OS CAMPOS OBRIGATORIOS(*) FORAM PREENCHIDOS*/
        private bool Verificacao()
        {
            bool verificado = false;
            bool cpf_verificado = util.validacaoCPF(txtCPF.Text);

            if (cpf_verificado == false ||  txtNomeFuncionario.Text == "" || txtCelular.Text == "" || txtCPF.Text == "" || txtRG.Text == "" || txtCEP.Text == "" || cbSEXO.Text == "" || txtBairro.Text == "")
            {
                if (cpf_verificado == false)
                {
                    MessageBox.Show("CPF Invalido", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
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
        }
        /*FUNCAO PARA CADASTRAR O FUNCIONARIO CUJO AS INFORMACOES FORAM PREENCHIDAS NOS CAMPOS OBRIGATORIOS*/
        private void Cadastrar()
        {
            bool verificado = Verificacao();
            if (verificado == true)
            {
                bool cpf = util.validacaoCPF(txtCPF.Text);
                if (cpf == false)
                {
                    MessageBox.Show("Cpf invalido");
                }
                else
                {
                    HospedeFisicoBLL hBLL = new HospedeFisicoBLL();
                    #region HBLLs
                    hBLL.Nome = txtNomeFuncionario.Text.ToString();
                    hBLL.Cpf = txtCPF.Text.ToString();
                    hBLL.dataNascimento = dtDate.Value.Date;
                    hBLL.Sexo = cbSEXO.Text.ToString();
                    hBLL.Cidade = txtCidade.Text.ToString();
                    hBLL.Uf = txtUF.Text.ToString();
                    hBLL.Cep = txtCEP.Text.ToString();
                    hBLL.Numero = txtNumero.Text.ToString();
                    hBLL.Complemento = txtComplemento.Text.ToString();
                    hBLL.Bairro = txtBairro.Text.ToString();
                    hBLL.Naturalidade = txtNaturalidade.Text.ToString();
                    hBLL.Celular = txtCelular.Text.ToString();
                    hBLL.Telefone = txtTelefone.Text.ToString();
                    hBLL.Rg = txtRG.Text.ToString();
                    hBLL.Endereco = txtEndereco.Text.ToString();
                    #endregion
                    //bool sucess = hDAO.cadastrandoHospede(hBLL);
                    //if (sucess == true)
                    //{
                    //    string msg = "Hospede Cadastrado com sucesso";
                    //    using (var Add = new Adicionado(msg))
                    //    {
                    //        Add.ShowDialog();
                    //    }
                    //}
                    //else
                    //{
                    //    //MessageBox.Show("Erro ao cadastrar hospede");
                    //}
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos com *", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region BUTTONS
        private void btnADD_Click(object sender, EventArgs e)
        {
            Cadastrar();
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

        private void txtCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtCEP.Text))
                {

                    CorreiosApi correios = new CorreiosApi();
                    try
                    {
                        var retorno = correios.consultaCEP(txtCEP.Text);

                        txtBairro.Text = retorno.bairro;
                        txtCidade.Text = retorno.cidade;
                        txtEndereco.Text = retorno.end;
                        txtUF.Text = retorno.uf;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }
    }
}
