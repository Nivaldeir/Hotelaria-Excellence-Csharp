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

namespace HotelExcellence.Telas.Nv2.listagem.Modals.Add
{
    public partial class editeEstoqueFRM : Form
    {
        EstoqueBLL eBLL = new EstoqueBLL();
        EstoqueDAO eDAO = new EstoqueDAO();
        public editeEstoqueFRM()
        {
            InitializeComponent();
        }

        public editeEstoqueFRM(int ID): this()
        {
            this.txtProduto.Select();

            if (ID == 0)
            {
            }
            else
            {
                string sql = "SELECT ID, produto, preco, quantidade FROM tbl_Estoque WHERE ID = " + ID;
                eBLL = eDAO.Search(sql);
                txtProduto.Text = eBLL.Produto;
                txtPreco.Text = eBLL.Preco.ToString();
                eBLL.Id = ID;
            }
            
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool verificado = Verificacao();
            if (verificado == true)
            {
                eBLL.Produto = txtProduto.Text.ToString();
                eBLL.Preco = decimal.Parse(txtPreco.Text.ToString());

                if (eBLL.Id != 0)
                {
                    bool sucess = eDAO.Update("UPDATE tbl_Estoque SET produto =@produto, quantidade = @quantidade, preco = @preco WHERE ID = @ID");
                    if (sucess == true)
                    {
                        string msg = "Produto alterado com sucesso!";
                        using (var Add = new Adicionado(msg))
                        {
                            Add.ShowDialog();
                        }
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Erro");
                    }
                }
                if (eBLL.Id == 0)
                {
                    eBLL.Quantidade = 0;
                    bool sucess = eDAO.Insert("INSERT INTO tbl_Estoque(produto, preco, quantidade) VALUES (@produto, @preco, @quantidade)");
                    if (sucess == true)
                    {
                        string msg = "Produto cadastrado com sucesso!";
                        using (var Add = new Adicionado(msg))
                        {
                            Add.ShowDialog();
                        }
                        this.Hide();
                    }
                    else
                    {
                        string msg = "Erro ao cadastrar";
                        using (var erro = new Erro(msg))
                        {
                            erro.ShowDialog();
                        }
                    }
                }
               
            }
            else
            {
                MessageBox.Show("Para campo para ser preenchido");
            }
        }
        public bool Verificacao()
        {
            bool verificado = false;
            if (txtProduto.Text == "" || txtPreco.Text == "")
            {
                if (txtProduto.Text == "")
                {
                    this.txtProduto.BorderColorIdle = Color.Red;

                }

                if (txtPreco.Text == "")
                {
                    this.txtPreco.BorderColorIdle = Color.Red;
                }
                verificado = false;
            }
            
            else
            {
                verificado = true;
            }

            return verificado;
        }
    }
}
