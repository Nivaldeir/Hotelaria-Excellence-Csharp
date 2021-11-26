
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
    public partial class ServicosCadastrosFRM : Form
    {

        #region INSTANCIAS
        DepartamentoDAO dDAO = new DepartamentoDAO();
        DepartamentoBLL dBLL = new DepartamentoBLL();
        EstoqueDAO eDAO = new EstoqueDAO();
        EstoqueBLL eBLL = new EstoqueBLL();

        ServiceDAO sDAO = new ServiceDAO();
        ServicesBLL sBLL = new ServicesBLL();

        #endregion
        public ServicosCadastrosFRM()
        {
            InitializeComponent();

            #region Combox Departamento
            string sql = "SELECT * FROM tbl_Departamento";
            DataTable dtDepartamento = dDAO.BuscandoTudo(sql);
            cbDepartamento.DataSource = dtDepartamento;
            cbDepartamento.DisplayMember = "nome";
            //cbDepartamento.ValueMember = "ID";
            #endregion
            #region Combox Estoque
            sql = "SELECT * FROM tbl_Estoque";
            DataTable dtEstoque = dDAO.BuscandoTudo(sql);
            cbItem.DataSource = dtEstoque;
            cbItem.DisplayMember = "produto";
            //cbItem.ValueMember = "ID";
            #endregion

        }

        private void cadServicesFRM_Load(object sender, EventArgs e)
        {
            txtService.Select();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            sBLL.Quantidade = int.Parse(txtQuantidade.Text.ToString());
            sBLL.Servico = txtService.Text.ToString();
            sBLL.Valor = decimal.Parse(txtValor.Text.ToString());

            string sql = "SELECT ID, produto, preco, quantidade FROM tbl_Estoque WHERE produto LIKE '"+ cbItem.Text + "'";
            eBLL = eDAO.Search(sql);
            sBLL.idEstoque = eBLL.Id;

            sql = "SELECT id, nome FROM tbl_Departamento WHERE nome LIKE '" + cbDepartamento.Text + "'";
            dBLL = dDAO.Pesquisa(sql);
            sBLL.idDepartamento = dBLL.Id;

          
            try
            {
                bool insert = sDAO.Insert(sBLL);
                if (insert == true)
                {
                    string msg = "Cadastrado com sucesso";
                    using (var Add = new Adicionado(msg))
                    {
                        Add.ShowDialog();
                    }
                    //MessageBox.Show("Sucesso");
                }
                else
                {
                    string msg = "Erro ao cadastrar";
                    using (var erro = new Erro(msg))
                    {
                        erro.ShowDialog();
                    }
                    //MessageBox.Show("Erro");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
