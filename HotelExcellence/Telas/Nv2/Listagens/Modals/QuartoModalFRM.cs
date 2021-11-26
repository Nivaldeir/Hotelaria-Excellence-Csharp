using Banco;
using Classes;
using HotelExcellence.Telas.Modals;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace HotelExcellence.Telas.Nv2.listagem.Modals
{
    public partial class editeQuartoFRM : Form
    {
        bool verificado = false;
        QuartosBLL qBLL = new QuartosBLL();
        QuartosDAO qDAO = new QuartosDAO();
        Geral geral = new Geral();

        Bitmap bmp;
        public editeQuartoFRM()
        {
            InitializeComponent();
            
        }
        public editeQuartoFRM(int ID): this()
        {
            if (ID == 0)
            { 
            }
            else
            {
                try
                {
                    string sql = "SELECT ID, nome, descricao, qtd_cama, qtd_banheiro, qtd_tv, preco, numero, foto FROM tbl_Quarto WHERE ID LIKE '%" + ID + "%' ";
                    qBLL = qDAO.Search(sql);
                    txtDescriçao.Text = qBLL.Descricao;
                    txtBanheiros.Text = qBLL.quantidadeBanheiro.ToString();
                    txtCamas.Text = qBLL.quantidadeCama.ToString();
                    txtDiariaQuarto.Text = qBLL.Preco.ToString();
                    txtNomeQuarto.Text = qBLL.Nome.ToString();
                    txtNumero.Text = qBLL.Numero.ToString();
                    txttv.Text = qBLL.quantidadeTv.ToString();
                    
                    if (qBLL == null)
                    {

                    }
                    else
                    {
                        MemoryStream imagem = new MemoryStream(qBLL.Foto);
                        picQuarto.Image = Image.FromStream(imagem);
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void editeQuartoFRM_Load(object sender, EventArgs e)
        {

        }

        public bool Verificacao()
        {
            if (txtNomeQuarto.Text == "")
            {
                this.txtNomeQuarto.BorderColorIdle = Color.Red;
                verificado = false;
            }

            if (txtDescriçao.Text == "")
            {
                this.txtDescriçao.BorderColorIdle = Color.Red;
                verificado = false;
            }
            if (txtNumero.Text == "")
            {
                this.txtNumero.BorderColorIdle = Color.Red;
                verificado = false;
            }
            if (txtDiariaQuarto.Text == "")
            {
                this.txtDiariaQuarto.BorderColorIdle = Color.Red;
                verificado = false;
            }
            else
            {
                verificado = true;
            }

            return verificado;
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            Verificacao();
            if (verificado == true)
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
                }
                catch (Exception)
                {

                    throw;
                }
               

                if (qBLL.Id !=0)
                {
                    string sql = "UPDATE tbl_Quarto SET " +
                        "nome ='%"+qBLL.Nome+ "%', " +
                        "descricao ='%"+qBLL.Descricao+"%', " +
                        "numero ='%" + qBLL.Numero + "%' , " +
                        "preco ='%" + qBLL.Preco + "%',  " +
                        "qtd_banheiro ='%" + qBLL.quantidadeBanheiro + "%' , " +
                        "qtd_cama = '%" + qBLL.quantidadeCama + "%', " +
                        "qtd_tv ='%" + qBLL.quantidadeTv + "%', " +
                        "foto= '%" + qBLL.Foto + "%'   WHERE ID = '%" + qBLL.Id + "%'";

                    bool sucess = qDAO.Update(sql);
                    if (sucess == true)
                    {
                        
                        string msg = "Cadastrado com sucesso";
                        using (var Add = new Adicionado(msg))
                        {
                            Add.ShowDialog();
                        }
                        this.Hide();

                    }
                }
                if (qBLL.Id == 0)
                {
                    string sql = "INSERT INTO " +
                        "tbl_Quarto (nome, descricao, qtd_cama, qtd_banheiro, qtd_tv, preco, numero, foto) " +
                        "Values " +
                        "('%"+ qBLL.Nome+"%', '%"+qBLL.Descricao+"%', '%"+qBLL.quantidadeCama+"%', '%"+qBLL.quantidadeBanheiro+"%', '%"+qBLL.quantidadeTv+"%', '%"+qBLL.Preco+"%', '%"+qBLL.Numero+"%', '%"+qBLL.Foto+"%')";
                    bool sucess = qDAO.Insert(sql);
                    if (sucess == true)
                    {
                        string msg = "Cadastrado com sucesso";
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
