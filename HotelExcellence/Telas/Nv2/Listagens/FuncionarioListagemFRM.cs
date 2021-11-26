using Banco;
using Classes;
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

namespace HotelExcellence.Telas.Nv2.listagem
{
    public partial class listFuncionario : Form
    {
        #region INSTANCIAMENTO
        FuncionarioBLL fBLL = new FuncionarioBLL();
        FuncionarioDAO fDAO = new FuncionarioDAO();
        
        #endregion

        static listFuncionario _obj;

        public static listFuncionario Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new listFuncionario();
                }
                return _obj;
            }
        }
        public listFuncionario()
        {
            InitializeComponent();
            _obj = this;
            Popular("");
        }
        public void Popular(string pesquisa)
        {
            flowLayoutPanel1.Controls.Clear();
            string sql = "SELECT D.nome AS Departamento, f.ID, f.foto, f.nome, f.status, f.cpf, f.data_nascimento, f.sexo, f.cidade, f.uf , f.cep, f.numero, f.complemento, f.bairro, f.naturalidade, f.celular, f.telefone, f.rg, f.endereco, c.cargo FROM tbl_Funcionario AS F JOIN tbl_Cargos AS C ON C.ID = F.IDcargo JOIN tbl_Departamento AS D ON D.id = C.ID_Departamento WHERE f.nome LIKE '%" + pesquisa + "%' AND c.n_permissao <= " + 3;// Program.Global.nPermissao;
            DataTable dt = fDAO.BuscandoTudo(sql);
            userControlFuncionario[] listItemn = new userControlFuncionario[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listItemn[i] = new userControlFuncionario();

                listItemn[i].ID = int.Parse(dt.Rows[i]["ID"].ToString());
                listItemn[i].Nome = dt.Rows[i]["nome"].ToString();
                listItemn[i].Status = dt.Rows[i]["status"].ToString();
                listItemn[i].Cpf = dt.Rows[i]["cpf"].ToString();
                DateTime date = DateTime.Parse(dt.Rows[i]["data_nascimento"].ToString());
                listItemn[i].Nascimento = date.ToString("dd/MM/yyyy");
                listItemn[i].Sexo = dt.Rows[i]["sexo"].ToString();
                listItemn[i].Cidade = dt.Rows[i]["cidade"].ToString();
                listItemn[i].Uf = dt.Rows[i]["Uf"].ToString();
                listItemn[i].Numero = dt.Rows[i]["numero"].ToString();
                listItemn[i].Complemento = dt.Rows[i]["complemento"].ToString();
                listItemn[i].Bairro = dt.Rows[i]["bairro"].ToString();
                listItemn[i].Celular = dt.Rows[i]["celular"].ToString();
                listItemn[i].Telefone = dt.Rows[i]["telefone"].ToString();
                listItemn[i].Rg = dt.Rows[i]["rg"].ToString();
                listItemn[i].Endereco = dt.Rows[i]["endereco"].ToString();
                listItemn[i].Cargo = dt.Rows[i]["cargo"].ToString();
                listItemn[i].Departamento = dt.Rows[i]["Departamento"].ToString();
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

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Popular(txtPesquisa.Text);
            }
        }
    }
}
