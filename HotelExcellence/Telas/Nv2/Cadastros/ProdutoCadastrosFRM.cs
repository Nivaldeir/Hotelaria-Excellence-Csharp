using Banco;
using Classes;
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

namespace HotelExcellence.Telas.cadastros
{
    public partial class ProdutoCadastrosFRM : Form
    {
        #region INSTANCIAS
        EstoqueDAO eDAO = new EstoqueDAO();
        EstoqueBLL eBLL = new EstoqueBLL();

        #endregion

        public ProdutoCadastrosFRM()
        {
            InitializeComponent();
        }



        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool verificado = Verificacao();
            if (verificado == true)
            {
                eBLL.Produto = txtProduto.Text.ToString();
                eBLL.Preco = decimal.Parse(txtPreco.Text.ToString());
                eBLL.Quantidade = int.Parse(txtQuantidade.Text.ToString());

                bool pesquisa = eDAO.Pesquisa(eBLL.Produto.ToString());
                if (pesquisa == true)
                {
                    //MessageBox.Show("Produto já existente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string msg = "Produto já existente";
                    using (var erro = new Erro(msg))
                    {
                        erro.ShowDialog();
                    }
                }
                else
                {
                    bool sucess = eDAO.Insert("INSERT INTO tbl_Estoque(produto, preco, quantidade) VALUES (@produto, @preco, @quantidade)");
                    //if (int.Parse(txtQuantidade.Text) == 1 || int.Parse(txtQuantidade.Text) == 2 || int.Parse(txtQuantidade.Text) == 3)
                    try
                    {
                        if (sucess == true)
                        {
                            //MessageBox.Show("Cadastrado com sucesso", "", MessageBoxButtons.OK);
                            string msg = "Cadastrado com sucesso";
                            using (var Add = new Adicionado(msg))
                            {
                                Add.ShowDialog();
                            }
                            Clear();
                        }
                        else
                        {
                            string msg = "Erro ao cadastrar";
                            using (var erro = new Erro(msg))
                            {
                                erro.ShowDialog();
                            }
                           // MessageBox.Show("Erro ao cadastrar", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
               
                    
                //}
                //else
                //{
                //    MessageBox.Show("Erro ao cadastrar" + " Nivel de permissao de 1 a 3 ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
            }
            
        }
        #region Funcoes
        public bool Verificacao()
        {
            bool verificado = false;

            if (txtPreco.Text == "" || txtProduto.Text == "" || txtQuantidade.Text == "")
            {
                if (txtPreco.Text == "")
                {
                    this.txtPreco.BorderColorIdle = Color.Red;
                    //this.lnlNome.ForeColor = Color.Red;
                }

                if (txtQuantidade.Text == "")
                {
                    this.txtQuantidade.BorderColorIdle = Color.Red;
                    //this.lnlEmail.ForeColor = Color.Red;
                }

                if (txtProduto.Text == "")
                {
                    this.txtProduto.BorderColorIdle = Color.Red;
                    //this.lblCelular.ForeColor = Color.Red;
                }
            }
            else
            {
                verificado = true;
            }

            return verificado;
        }
        public void Clear()
        {
            txtPreco.Clear();
            txtProduto.Clear();
            txtQuantidade.Clear();
            txtProduto.Focus();
        }
        #endregion
    }
}
