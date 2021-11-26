
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

namespace HotelExcellence.Telas.acessoNv2.listagem
{
    public partial class listAcesso : Form
    {
        #region INSTANCIAR
        CargosDAO cDAO = new CargosDAO();
        #endregion

        static listAcesso _obj;
        public static listAcesso Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new listAcesso();
                }
                return _obj;
            }
        }
        public listAcesso()
        {
            
            InitializeComponent();
            _obj = this;
            acessoPopular("");
        }

        public void acessoPopular(string pesquisa)
        {
            
            string sql = "SELECT l.ID, f.nome, f.foto, l.email, l.login, l.senha, C.cargo, C.n_permissao, D.nome AS departamento FROM tbl_Login AS L JOIN tbl_Funcionario AS F ON F.ID = L.ID_FUNCIONARIO JOIN tbl_Cargos AS C ON C.ID = F.IDcargo JOIN tbl_Departamento AS D ON D.id = C.ID_Departamento";
            DataTable dt = cDAO.BuscandoTudo(sql);
            userControlAcesso[] listItemn = new userControlAcesso[dt.Rows.Count];
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listItemn[i] = new userControlAcesso();

                listItemn[i].ID = int.Parse(dt.Rows[i]["ID"].ToString());
                listItemn[i].Nome = dt.Rows[i]["nome"].ToString();
                listItemn[i].Email = dt.Rows[i]["email"].ToString();
                listItemn[i].Login = dt.Rows[i]["login"].ToString();
                listItemn[i].Senha = dt.Rows[i]["senha"].ToString();
                listItemn[i].Cargo = dt.Rows[i]["cargo"].ToString();
                listItemn[i].Acesso = dt.Rows[i]["n_permissao"].ToString();
                listItemn[i].Departamento = dt.Rows[i]["departamento"].ToString();
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
    }
}
