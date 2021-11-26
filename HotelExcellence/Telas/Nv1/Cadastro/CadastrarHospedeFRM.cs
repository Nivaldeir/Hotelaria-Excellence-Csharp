using Correios;
using HotelExcellence.Telas.Modals;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Classes;
using Util;
using Banco;

namespace HotelExcellence.Telas.acessoNv1
{
    public partial class CadastrarHospedeFRM : Form
    {
        Utils util = new Utils();

        HospedeDAO hDAO = new HospedeDAO();
        private bool validarCpnj = false ;
        public CadastrarHospedeFRM()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cadastrar();
        }

        private void txtCEP_TextChange(object sender, EventArgs e)
        {
            if (txtCEP.Text.Length >=8) {
                if (!string.IsNullOrEmpty(txtCEP.Text))
                {
                    CorreiosApi correios = new CorreiosApi();
                    var retorno = correios.consultaCEP(txtCEP.Text);
                    try
                    {
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
        private void txtCPF_TextChange_1(object sender, EventArgs e)
        {
            indentificadorCpnj(txtCPF.Text.ToString());
        } 
        private void Cadastrar()
        {
            bool verificado = Verificacao();
            if (verificado == true)
            {
                HospedeFisicoBLL hBLL = new HospedeFisicoBLL();
                #region HBLLs
                hBLL.Nome = txtNomeFuncionario.Text.ToString();
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

                if (!txtRazao.Text.Equals("") ){
                    hBLL.razaoSocial = txtRazao.Text.ToString();
                    hBLL.Cpnj = txtCPF.Text.ToString();

                    bool sucess = hDAO.cadastrandoHospedeCnpj(hBLL);
                    if (sucess == true)
                    {
                        string msg = "Hospede Cadastrado com sucesso";
                        using (var Add = new Adicionado(msg))
                        {
                            Add.ShowDialog();
                        }
                        limpaCampos();
                    }
                    else
                    {
                        //MessageBox.Show("Erro ao cadastrar hospede");
                    }
                }
                else {
                    hBLL.Cpf = txtCPF.Text.ToString();
                    bool sucess = hDAO.cadastrandoHospedeFisico(hBLL);
                    if (sucess == true)
                    {
                        string msg = "Hospede Cadastrado com sucesso";
                        using (var Add = new Adicionado(msg))
                        {
                            Add.ShowDialog();
                        }
                        limpaCampos();
                    }
                    else
                    {
                        //MessageBox.Show("Erro ao cadastrar hospede");
                    }

                }
            }
        }
        private bool Verificacao()
        {
            bool verificado = false;
            bool cpf_verificado = false;

            if (!txtRazao.Text.Equals(""))
            {
                validarCpnj = util.validacaoCNPJ(txtCPF.Text);
                if (!validarCpnj)
                {
                    MessageBox.Show("CNPJ Invalido", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    return verificado = false;
                }
                else if (!(txtRazao.Text.Length > 0))
                {
                    this.txtRazao.BorderColorIdle = Color.Red;
                    return verificado = false;
                }
            }
            else
            {
                cpf_verificado = util.validacaoCPF(txtCPF.Text);
                if (!cpf_verificado)
                {
                    MessageBox.Show("CPF Invalido", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    return verificado = false;
                }
            }
            if (txtNomeFuncionario.Text == "" || txtCelular.Text == "" || txtRG.Text == "" || txtCEP.Text == "" || cbSEXO.Text == "" || txtBairro.Text == "")
            {
                if (txtNomeFuncionario.Text == "")
                {
                    this.txtNomeFuncionario.BorderColorIdle = Color.Red;
                }
                else if (txtCelular.Text == "")
                {
                    this.txtCelular.BorderColorIdle = Color.Red;
                }
                else  if (txtRG.Text == "")
                {
                    this.txtRG.BorderColorIdle = Color.Red;
                }
                else if (txtCEP.Text == "")
                {
                    this.txtCEP.BorderColorIdle = Color.Red;
                }
                else if (txtBairro.Text == "")
                {
                    this.txtBairro.BorderColorIdle = Color.Red;
                }
                else if (txtNumero.Text == "")
                {
                    this.txtNumero.BorderColorIdle = Color.Red;
                }
                else if (cbSEXO.Text == "")
                {
                    this.cbSEXO.BorderColor = Color.Red;
                }
            }
            else
            {
                verificado = true;
            }
            return verificado;


        }/*FUNCAO PARA CADASTRAR O FUNCIONARIO CUJO AS INFORMACOES FORAM PREENCHIDAS NOS CAMPOS OBRIGATORIOS*/
        private void indentificadorCpnj(string cpf)
        {
            if (cpf.Length > 14)
            {
                validarCpnj = util.validacaoCNPJ(cpf);
                txtRazao.Visible = true;
                txtRazaoSocial.Visible = true;

            }
            else
            {
                txtRazao.Visible = false;
            }

        }

        private void limpaCampos() {
            txtNomeFuncionario.Clear();
            txtNumero.Clear();
            txtRazao.Clear();
            txtRG.Clear();
            txtTelefone.Clear();
            txtUF.Clear();
            txtNaturalidade.Clear();
            txtEndereco.Clear();
            txtCPF.Clear();
            txtCidade.Clear();
            txtCEP.Clear();
            txtCelular.Clear();
            txtBairro.Clear();
        }
    }
}
