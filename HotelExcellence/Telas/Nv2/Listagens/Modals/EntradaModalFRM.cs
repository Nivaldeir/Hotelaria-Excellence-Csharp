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

namespace HotelExcellence.Telas.Nv2.listagem.Modals
{
    public partial class entradaEstoqueFRM : Form
    {
        EstoqueDAO eDAO = new EstoqueDAO();
        EstoqueBLL eBLL = new EstoqueBLL();

        int estoque = 0;
        decimal valor, valorEstoque;
        public entradaEstoqueFRM()
        {
            InitializeComponent();
        }

        private void txtProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string sql = "SELECT ID, preco, produto, quantidade FROM tbl_Estoque WHERE produto LIKE '%" + txtProduto.Text + "%'";
                eBLL = eDAO.Search(sql);
                txtPreco.Text = eBLL.Preco.ToString();
                txtQuantidadeEstoque.Text = eBLL.Quantidade.ToString();

                estoque = eBLL.Quantidade;
                valor = decimal.Parse(txtPreco.Text.ToString());
                valorEstoque = estoque * valor;

                lblQuantidadeEstoque.Text = "Quantidade em estoque: " + estoque + "  Uni. -  Valor do estoque R$: " + valorEstoque;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtProduto.Text == "")
            {
                this.txtProduto.BorderColorIdle = Color.Red;
            }
            else
            {

                try
                {
                    eBLL.Produto = txtProduto.Text.ToString();
                    eBLL.Preco = decimal.Parse(txtPreco.Text.ToString());

                    eBLL.Quantidade = int.Parse(txtEntrada.Text.ToString()) + int.Parse(txtQuantidadeEstoque.Text.ToString());

                    bool isSucess = eDAO.Update("UPDATE tbl_Estoque SET produto =@produto, quantidade = @quantidade, preco = @preco WHERE ID = @ID");
                    if (isSucess == true)
                    {
                        string msg = "Estoque alterado com sucesso!";
                        using (var Add = new Adicionado(msg))
                        {
                            Add.ShowDialog();
                        }
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Erro E-S");
                    }
                }
                catch (Exception)
                {

                    throw;
                }
               
            }
        }

        private void txtEntrada_TextChange(object sender, EventArgs e)
        {
            if (txtEntrada.Text == "")
            {
                return;
            }
            estoque = eBLL.Quantidade + int.Parse(txtEntrada.Text);
            valorEstoque = estoque * valor;

            lblQuantidadeEstoque.Text = "Quantidade em estoque: " + estoque +  "  Uni. -  Valor do estoque R$: " + valorEstoque;
        }
    }
}
