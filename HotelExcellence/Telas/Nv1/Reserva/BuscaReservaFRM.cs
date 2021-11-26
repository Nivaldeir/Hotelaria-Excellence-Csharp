
using Banco;
using HotelExcellence.Telas.Modals;
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

namespace HotelExcellence.Telas.Nv1.Reserva
{
    public partial class BuscaReservaFRM : Form
    {
        ReservaDAO rDAO = new ReservaDAO();
        static BuscaReservaFRM _obj;

        public static BuscaReservaFRM Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new BuscaReservaFRM();
                }
                return _obj;
            }
        }


        public BuscaReservaFRM()
        {
            InitializeComponent();
        }


       public void Popular(string cpf)
        {
            flowLayoutPanel1.Controls.Clear();
            string sql = "SELECT R.ID, R.reserva AS Reserva, Q.nome AS NomeQuarto, Q.preco, Q.foto, H.nome AS NomeHospede, H.cpf, H.cnpj, H.rg, H.sexo, H.data_nascimento AS DataNascimento FROM tbl_Reserva AS R JOIN tbl_Quarto AS Q ON Q.ID = R.ID_QUARTO JOIN tbl_Hospede AS H ON H.ID = R.ID_HOSPEDE WHERE cpf ='"+ cpf+"' or cnpj'"+ cpf +"'";// Program.Global.nPermissao;
            DataTable dt = rDAO.BuscandoTudo(sql);
            userControlConsulta[] listItemn = new userControlConsulta[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listItemn[i] = new userControlConsulta();

                listItemn[i].ID = int.Parse(dt.Rows[i]["ID"].ToString());
                DateTime dateReserva = DateTime.Parse(dt.Rows[i]["Reserva"].ToString());
                listItemn[i].Reserva = dateReserva.ToString("dd/MM/yyyy");
                listItemn[i].NomeQuarto = dt.Rows[i]["NomeQuarto"].ToString();
                listItemn[i].NomeHospede = dt.Rows[i]["NomeHospede"].ToString();
                listItemn[i].Preco = decimal.Parse(dt.Rows[i]["preco"].ToString());
                listItemn[i].Cpf = dt.Rows[i]["cpf"].ToString();
                DateTime date = DateTime.Parse(dt.Rows[i]["DataNascimento"].ToString());
                listItemn[i].Nascimento = date.ToString("dd/MM/yyyy");
                listItemn[i].Sexo = dt.Rows[i]["sexo"].ToString();
              
                listItemn[i].Rg = dt.Rows[i]["rg"].ToString();

                if (dt.Rows[i]["foto"].ToString() != "")
                {
                    MemoryStream imagem = new MemoryStream((byte[])dt.Rows[i]["foto"]);
                    listItemn[i].Foto = Image.FromStream(imagem);
                }
                else
                {
                    string img2 = System.Environment.CurrentDirectory + @"\imgs\semFoto.png";
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
                    listItemn[i].Foto = zerado;
                }
                flowLayoutPanel1.Controls.Add(listItemn[i]);
            }

        }



        private void BuscaReservaFRM_Load(object sender, EventArgs e)
        {
            txtPesquisaReservas.Select();
            _obj = this;
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            Popular(txtPesquisaReservas.Text);
        }

        private void txtPesquisaReservas_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Popular(txtPesquisaReservas.Text);
            }
        }

        public void Selecionado()
        {
            txtPesquisaReservas.Select();
        }
    }
}
