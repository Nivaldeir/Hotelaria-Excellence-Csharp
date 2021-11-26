using Banco;
using Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelExcellence.Telas.Nv2.listagem
{
    public partial class serviceFRM : Form
    {
        ServiceDAO sDAO= new ServiceDAO();
        ServicesBLL sBLL= new ServicesBLL();
        public serviceFRM()
        {
            InitializeComponent();
        }

        private void serviceFRM_Load(object sender, EventArgs e)
        {
            string sql = "SELECT s.ID, s.servico, s.valor AS valorServico, E.produto, e.preco, D.nome FROM tbl_ServicoConsumo AS S JOIN tbl_Estoque AS E ON E.ID = S.ID JOIN tbl_Departamento AS D ON D.id = S.ID";
            DataTable dt = sDAO.BuscandoTudo(sql);
            dtgService.DataSource = dt;
            DataGrid();
            txtPesquisa.Select();
        }

        private void DataGrid()
        {
            dtgService.Columns["ID"].Visible = false;
            dtgService.Columns["servico"].HeaderText = "Nome do serviço";
            dtgService.Columns["valorServico"].HeaderText = "Valor do serviço";
            dtgService.Columns["produto"].HeaderText = "Nome do produto";
            dtgService.Columns["preco"].HeaderText = "Preço do produto";

            dtgService.Columns["nome"].HeaderText = "Departamento";

            dtgService.Columns["Icon"].DisplayIndex = 0;
            dtgService.Columns["servico"].DisplayIndex = 1;
            dtgService.Columns["valorServico"].DisplayIndex = 2;
            dtgService.Columns["produto"].DisplayIndex = 3;
            dtgService.Columns["preco"].DisplayIndex = 4;
            dtgService.Columns["nome"].DisplayIndex = 5;
            dtgService.Columns["Deletar"].DisplayIndex = 6;
        }

        private void txtPesquisa_TextAlignChanged(object sender, EventArgs e)
        {
           
        }

        private void txtPesquisa_TextChange(object sender, EventArgs e)
        {
            string sql = "SELECT s.ID, s.servico, s.valor AS valorServico, E.produto, e.preco, D.nome FROM tbl_ServicoConsumo AS S JOIN tbl_Estoque AS E ON E.ID = S.ID JOIN tbl_Departamento AS D ON D.id = S.ID WHERE d.nome LIKE '%" + txtPesquisa.Text + "%' or s.servico LIKE '%" + txtPesquisa.Text + "%' ";
            DataTable dt = sDAO.BuscandoTudo(sql);
            dtgService.DataSource = dt;
        }

        private void dtgService_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                ScrolBar.Maximum = dtgService.RowCount - 1;
            }
            catch (Exception)
            {
            }
        }

        private void dtgService_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                ScrolBar.Maximum = dtgService.RowCount - 1;
            }
            catch (Exception)
            {
            }
        }

        private void ScrolBar_Scroll(object sender, ScrollEventArgs e)
        {
            try
            {
                dtgService.FirstDisplayedScrollingRowIndex = dtgService.Rows[e.NewValue].Index;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dtgService_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int RowIndex = e.RowIndex;
                sBLL.Id = int.Parse(dtgService.Rows[RowIndex].Cells["ID"].Value.ToString());
            }
            catch (Exception)
            {

            }

            string colName = dtgService.Columns[e.ColumnIndex].Name;

            if (colName == "Deletar")
            {
                string sql = "DELETE FROM tbl_ServicoConsumo WHERE ID =" + sBLL.Id;
                if (MessageBox.Show("Deseja excluir o Serviço?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bool sucess = sDAO.Deletando(sql);

                    if (sucess == true)
                    {
                        MessageBox.Show("Servico excluido com sucesso!");

                        sql = "SELECT s.ID, s.servico, s.valor AS valorServico, E.produto, e.preco, D.nome FROM tbl_ServicoConsumo AS S JOIN tbl_Estoque AS E ON E.ID = S.ID JOIN tbl_Departamento AS D ON D.id = S.ID";
                        DataTable dt = sDAO.BuscandoTudo(sql);
                        dtgService.DataSource = dt;

                    }
                }
            }
        }
    }
}
