using Banco;
using Classes;
using HotelExcellence.Telas.Nv2.listagem.Modals;
using HotelExcellence.Telas.Nv2.listagem.Modals.Add;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelExcellence.Telas.Nv2.listagem
{
    public partial class estoqueFRM : Form
    {
        EstoqueBLL eBLL = new EstoqueBLL();
        EstoqueDAO eDAO = new EstoqueDAO();
        string sql = "";
        public estoqueFRM()
        {
            InitializeComponent();
            buscandoEstoque();
            DataGrid();
        }

        private void estoqueFRM_Load(object sender, EventArgs e)
        {
            Estilizacao();
        }

        public void DataGrid()
        {
            dtgEstoque.Columns["ID"].Visible = false;
            dtgEstoque.Columns["produto"].HeaderText = "Nome do produto";
            dtgEstoque.Columns["preco"].HeaderText = "Preço Un.";
            dtgEstoque.Columns["quantidade"].HeaderText = "Quantidade";

            dtgEstoque.Columns["Icon"].DisplayIndex = 0;
            dtgEstoque.Columns["produto"].DisplayIndex = 1;
            dtgEstoque.Columns["preco"].DisplayIndex = 2;
            dtgEstoque.Columns["quantidade"].DisplayIndex = 3;
            dtgEstoque.Columns["Status"].DisplayIndex = 4;
            dtgEstoque.Columns["Editar"].DisplayIndex = 5;
            dtgEstoque.Columns["Deletar"].DisplayIndex = 6;

            dtgEstoque.Columns["Icon"].Width = 20;
            dtgEstoque.Columns["Editar"].Width = 60;
            dtgEstoque.Columns["Deletar"].Width = 60;

        }

        public Image ESGOTADO()
        {
            string img1 = System.Environment.CurrentDirectory + @"\imgs\ESGOTADO_.png";
            string _strTexto = img1;
            Bitmap _bmpOut = new Bitmap(200, 50);
            Graphics _graphs = Graphics.FromImage(_bmpOut);
            _graphs.DrawString(_strTexto, new Font("Arial", 14), new SolidBrush(Color.Black), 0, 0);

            MemoryStream ms = new MemoryStream();
            _bmpOut.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

            byte[] bmpBytes = ms.GetBuffer();
            _bmpOut.Dispose();
            ms.Close();

            Image zerado = Image.FromFile(img1);
            return zerado;
        }
        public Image ESTOQUEALTO()
        {
            string img3 = System.Environment.CurrentDirectory + @"\imgs\estoqueAlto.png";
            string _strTexto = img3;
            Bitmap _bmpOut = new Bitmap(200, 50);
            Graphics _graphs = Graphics.FromImage(_bmpOut);
            _graphs.DrawString(_strTexto, new Font("Arial", 14), new SolidBrush(Color.Black), 0, 0);

            MemoryStream ms = new MemoryStream();
            _bmpOut.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

            byte[] bmpBytes = ms.GetBuffer();
            _bmpOut.Dispose();
            ms.Close();

            Image zerado = Image.FromFile(img3);
            return zerado;
        }

        public Image ESTOQUEBAIXO()
        {
            string img2 = System.Environment.CurrentDirectory + @"\imgs\estoqueBaixo.png";
            string _strTexto = img2;
            Bitmap _bmpOut = new Bitmap(200, 50);
            Graphics _graphs = Graphics.FromImage(_bmpOut);
            _graphs.DrawString(_strTexto, new Font("Arial", 14), new SolidBrush(Color.Black), 0, 0);

            MemoryStream ms = new MemoryStream();
            _bmpOut.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

            byte[] bmpBytes = ms.GetBuffer();
            _bmpOut.Dispose();
            ms.Close();

            Image zerado = Image.FromFile(img2);
            return zerado;
        }
        public void Estilizacao()
        {

            for (int i = 0; i < dtgEstoque.RowCount; i++)
            {
                //Estoque critico color red
                if (int.Parse(dtgEstoque.Rows[i].Cells["quantidade"].Value.ToString()) <= 0)
                {

                    dtgEstoque.Rows[i].Cells["Status"].Value = ESGOTADO();
                }

                else if (int.Parse(dtgEstoque.Rows[i].Cells["quantidade"].Value.ToString()) > 0 && int.Parse(dtgEstoque.Rows[i].Cells["quantidade"].Value.ToString()) <= 20)
                {

                    dtgEstoque.Rows[i].Cells["Status"].Value = ESTOQUEBAIXO();
                }

                else if (int.Parse(dtgEstoque.Rows[i].Cells["quantidade"].Value.ToString()) >= 21)
                {
                    dtgEstoque.Rows[i].Cells["Status"].Value = ESTOQUEALTO();
                }
            }
        }
        private void txtPesquisa_TextChange(object sender, EventArgs e)
        {
            sql = "SELECT * FROM tbl_Estoque WHERE produto LIKE '%" + txtPesquisa.Text + "%'";
            DataTable dt = eDAO.BuscandoTudo(sql);
            dtgEstoque.DataSource = dt;
            Estilizacao();
        }

        private void dtgQuartos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int RowIndex = e.RowIndex;
                eBLL.Id = int.Parse(dtgEstoque.Rows[RowIndex].Cells["ID"].Value.ToString());
            }
            catch (Exception)
            {

            }

            string colName = dtgEstoque.Columns[e.ColumnIndex].Name;

            if (colName == "Editar")
            {
                //MessageBox.Show("Editar");
                using (var estoque = new editeEstoqueFRM(eBLL.Id))
                {
                    estoque.ShowDialog();
                    buscandoEstoque();
                    //editeQuarto.Show();
                }
            }

            if (colName == "Deletar")
            {
                string sql = "DELETE FROM tbl_Estoque WHERE ID =" + eBLL.Id;
                if (MessageBox.Show("Deseja excluir o produto", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bool sucess = eDAO.Deletando(sql);

                    if (sucess == true)
                    {
                        MessageBox.Show("Produto excluido com sucesso!");
                    }
                }
                buscandoEstoque();
            }
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            eBLL.Id = 0;
            using (var estoque = new editeEstoqueFRM(eBLL.Id))
            {
                estoque.ShowDialog();
            }   
        }

        private void dtgEstoque_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Estilizacao();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            using (var estoque = new entradaEstoqueFRM())
            {
                estoque.ShowDialog();
            }
        }

        private void dtgEstoque_Scroll(object sender, ScrollEventArgs e)
        {
            try
            {
                dtgEstoque.FirstDisplayedScrollingRowIndex = dtgEstoque.Rows[e.NewValue].Index;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ScrolBar_Scroll(object sender, ScrollEventArgs e)
        {
            try
            {
                dtgEstoque.FirstDisplayedScrollingRowIndex = dtgEstoque.Rows[e.NewValue].Index;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dtgEstoque_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                ScrolBar.Maximum = dtgEstoque.RowCount - 1;
            }
            catch (Exception)
            {

            }
        }

        private void dtgEstoque_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                ScrolBar.Maximum = dtgEstoque.RowCount - 1;
            }
            catch (Exception)
            {

            }
        }

        private void buscandoEstoque() {
            sql = "SELECT * FROM tbl_Estoque";
            DataTable dt = eDAO.BuscandoTudo(sql);
            dtgEstoque.DataSource = dt;
            Estilizacao();
        }
    }
}
