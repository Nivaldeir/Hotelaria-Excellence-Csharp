using Banco;
using Classes;
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

namespace HotelExcellence.Telas.cadastros
{
    public partial class QuartoCadastrosFRM : Form
    {
        bool verificado = false;
        QuartosBLL qBLL = new QuartosBLL();
        QuartosDAO qDAO = new QuartosDAO();
        Bitmap bmp;
        public QuartoCadastrosFRM()
        {
            InitializeComponent();
            txtNomeQuarto.Select();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Verificacao();
            if (verificado == true)
            {
                string sql = "SELECT  nome, descricao, qtd_cama, qtd_banheiro, qtd_tv, preco, numero, foto FROM tbl_Quarto WHERE nome LIKE '%" + txtNomeQuarto.Text.ToString() + "%'";
                qBLL = qDAO.Search(sql);
                if (qBLL.Nome == txtNomeQuarto.Text.ToString() && qBLL.Numero == txtNumero.Text.ToString())
                {
                    string msg = "Quarto já existente";
                    using (var erro = new Erro(msg))
                    {
                        erro.ShowDialog();
                    }
                }
                else
                {
                    try
                    {
                        qBLL.Nome = txtNomeQuarto.Text.ToString();
                        qBLL.Descricao = txtDescriçao.Text.ToString();
                        qBLL.Numero = txtNumero.Text.ToString();
                        qBLL.Preco = decimal.Parse(txtDiariaQuarto.Text.ToString());
                        qBLL.quantidadeBanheiro= int.Parse(txtBanheiros.Text.ToString());
                        qBLL.quantidadeCama = int.Parse(txtCamas.Text.ToString());
                        qBLL.quantidadeTv = int.Parse(txttv.Text.ToString());

                        MemoryStream memory = new MemoryStream();
                        bmp.Save(memory, ImageFormat.Bmp);
                        qBLL.Foto = memory.ToArray();
                        sql = "INSERT INTO " +
                        "tbl_Quarto (nome, descricao, qtd_cama, qtd_banheiro, qtd_tv, preco, numero, foto) " +
                        "Values " +
                        "('%" + qBLL.Nome + "%', '%" + qBLL.Descricao + "%', '%" + qBLL.quantidadeCama + "%', '%" + qBLL.quantidadeBanheiro + "%', '%" + qBLL.quantidadeTv + "%', '%" + qBLL.Preco + "%', '%" + qBLL.Numero + "%', '%" + qBLL.Foto + "%')";
                        bool sucess = qDAO.Insert(sql);
                        if (sucess == true)
                        {
                            string msg = "Cadastrado com sucesso";
                            using (var Add = new Adicionado(msg))
                            {
                                Add.ShowDialog();
                            }
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
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
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
            if (txtNomeQuarto.Text == "" || txtDescriçao.Text == "" || txtDiariaQuarto.Text == "")
            {
                verificado = false;
                if (txtNomeQuarto.Text == "")
                {
                    this.txtNomeQuarto.BorderColorIdle = Color.Red;
                   
                }
                if (txtDescriçao.Text == "")
                {
                    this.txtDescriçao.BorderColorIdle = Color.Red;
                }
                if (txtNumero.Text == "")
                {
                    this.txtNumero.BorderColorIdle = Color.Red;
                }
                if (txtDiariaQuarto.Text == "")
                {
                    this.txtDiariaQuarto.BorderColorIdle = Color.Red;
                }
            }
            else
            {
                verificado = true;
            }

            return verificado;
        }


        #region ATALHOS TECLHAS
        private void txtNomeQuarto_Load(object sender, EventArgs e)
        {
            txtNomeQuarto.Select();
        }

        private void txtNomeQuarto_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void txtSubtituloQuarto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDiariaQuarto.Focus();
            }
        }

        private void txtDiariaQuarto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNumero.Focus();
            }
        }

        private void txtNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDescriçao.Focus();
            }
        }

        #endregion

        private void btnADD_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG Files(*.jpg)|*jpg|PNG Files(*png)|*.png |ALLFiles(*.*)| *.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foto = dialog.FileName;
                bmp = new Bitmap(foto);
            }
        }
    }
}
