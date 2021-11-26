using Banco;
using Classes;
using HotelExcellence.Telas.Nv2.listagem.Modals;
using System;
using System.Data;
using System.Windows.Forms;

namespace HotelExcellence.Telas
{
    public partial class quartosFRM : Form
    {
        #region INSTANCIAS
        QuartosBLL qBLL = new QuartosBLL();
        QuartosDAO qDAO = new QuartosDAO();
        #endregion

        #region VARIAVEIS
        private string sql = "";
        private int RowIndex = 0;
        #endregion
        public quartosFRM()
        {
            InitializeComponent();

            buscandoQuartos();
            this.txtPesquisa.Select();
            qBLL.Id = 0;
            DataGrid();

        }
        private void dtgQuartos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                RowIndex = e.RowIndex;
                qBLL.Id = int.Parse(dtgQuartos.Rows[RowIndex].Cells["ID"].Value.ToString());
            }
            catch (Exception)
            {

            }

            string colName = dtgQuartos.Columns[e.ColumnIndex].Name;

            if (colName == "Editar")
            {
                using (var editeQuarto = new editeQuartoFRM(qBLL.Id))
                {
                    editeQuarto.ShowDialog();
                    buscandoQuartos();
                }
            }

            if (colName == "Deletar")
            {
                string sql = "DELETE FROM tbl_Quarto WHERE ID =" + qBLL.Id;
                if (MessageBox.Show("Deseja excluir o cadastro", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bool sucess = qDAO.Deletando(sql);

                    if (sucess == true)
                    {
                        MessageBox.Show("Quarto excluido com sucesso!");
                        buscandoQuartos();
                    }
                }
            }
        }

        private void quartosFRM_Load(object sender, EventArgs e)
        {
        }

        private void txtPesquisa_TextChange_1(object sender, EventArgs e)
        {
            sql = "SELECT * FROM tbl_Quarto WHERE nome LIKE '%" + txtPesquisa.Text + "%' or numero LIKE '%" + txtPesquisa.Text + "%'";
            DataTable dt = qDAO.BuscandoTudo(sql);
            dtgQuartos.DataSource = dt;
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            int insert = 0;
            using (var editeQuarto = new editeQuartoFRM(insert))
            {
                editeQuarto.ShowDialog();
                buscandoQuartos();
                editeQuarto.Show();
            }
        }

        private void DataGrid()
        {
            #region DATAGRID
            dtgQuartos.Columns["ID"].Visible = false;
            dtgQuartos.Columns["foto"].Visible = false;
            dtgQuartos.Columns["nome"].HeaderText = "Nome do Quarto";
            dtgQuartos.Columns["subtitulo"].HeaderText = "Subtitulo";
            dtgQuartos.Columns["descricao"].HeaderText = "Descrição";
            dtgQuartos.Columns["qtd_cama"].HeaderText = "Camas";
            dtgQuartos.Columns["qtd_banheiro"].HeaderText = "Banheiros";
            dtgQuartos.Columns["qtd_tv"].HeaderText = "TV";
            dtgQuartos.Columns["preco"].DefaultCellStyle.Format = "C";
            dtgQuartos.Columns["preco"].HeaderText = "Diaria";
            dtgQuartos.Columns["numero"].HeaderText = "Numero";
            dtgQuartos.Columns["foto"].HeaderText = "Fotos";

            dtgQuartos.Columns["icon"].DisplayIndex = 0;
            dtgQuartos.Columns["nome"].DisplayIndex = 1;
            dtgQuartos.Columns["subtitulo"].DisplayIndex = 2;
            dtgQuartos.Columns["descricao"].DisplayIndex = 3;
            dtgQuartos.Columns["qtd_cama"].DisplayIndex = 4;
            dtgQuartos.Columns["qtd_banheiro"].DisplayIndex = 5;
            dtgQuartos.Columns["qtd_tv"].DisplayIndex = 6;
            dtgQuartos.Columns["preco"].DisplayIndex = 7;
            dtgQuartos.Columns["preco"].DisplayIndex = 8;
            dtgQuartos.Columns["numero"].DisplayIndex = 9;

            dtgQuartos.Columns["Editar"].DisplayIndex = 10;
            dtgQuartos.Columns["Deletar"].DisplayIndex = 11;

            dtgQuartos.Columns["qtd_tv"].Width = 40;
            dtgQuartos.Columns["qtd_cama"].Width = 40;
            dtgQuartos.Columns["qtd_banheiro"].Width = 50;
            dtgQuartos.Columns["Editar"].Width = 60;
            dtgQuartos.Columns["Deletar"].Width = 60;

            #endregion
        }


        private void ScrolBar_Scroll(object sender, ScrollEventArgs e)
        {
            try
            {
                dtgQuartos.FirstDisplayedScrollingRowIndex = dtgQuartos.Rows[e.NewValue ].Index;
            }
            catch (Exception)
            {
            }
            
        }

        private void dtgQuartos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                ScrolBar.Maximum = dtgQuartos.RowCount - 1;
            }
            catch (Exception)
            {

            }
        }

        private void dtgQuartos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                ScrolBar.Maximum = dtgQuartos.RowCount - 1;
            }
            catch (Exception)
            {
            }

        }

        private void dtgQuartos_Scroll(object sender, ScrollEventArgs e)
        {
            try
            {
                ScrolBar.Maximum = dtgQuartos.RowCount - 1;
            }
            catch (Exception)
            {
            }
        }

        private void buscandoQuartos() {
            sql = "SELECT * FROM tbl_Quarto";
            DataTable dt = qDAO.BuscandoTudo(sql);
            dtgQuartos.DataSource = dt;
        }

        private void dtgQuartos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
