
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes;
using Banco;

namespace HotelExcellence.Telas.Nv3.cadastros
{
    public partial class cadDepartamentoFRM3 : Form
    {

        #region INSTANCIAS
        DepartamentoBLL dBLL = new DepartamentoBLL();
        DepartamentoDAO dDAO = new DepartamentoDAO();
        #endregion
        public cadDepartamentoFRM3()
        {
            InitializeComponent();
        }

        private void cadDepartamentoFRM3_Load(object sender, EventArgs e)
        {
            txtDepartamento.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool verificado = Verificar();
            if (verificado == true)
            {
                string sql = "INSERT INTO tbl_Departamento(nome) VALUES ('%"+txtDepartamento.Text.ToString()+"%')";
                bool insert = dDAO.Insert(sql);

                if ( insert == true)
                {
                    MessageBox.Show("Departamento cadastrado com sucesso!");
                    clear();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar o departamento", "", MessageBoxButtons.OK);
                }
            }

        }
        public bool Verificar()
        {
            bool verificado = false;
            if (txtDepartamento.Text == "")
            {
                this.txtDepartamento.BorderColorDisabled = Color.Red;
                verificado = false;
            }
            else
            {
                verificado = true;
            }
            return verificado;
        }
        public void clear(){
            txtDepartamento.Clear();
            txtDepartamento.Focus();
        }

    }
}
