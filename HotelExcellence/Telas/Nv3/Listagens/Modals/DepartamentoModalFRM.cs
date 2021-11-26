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

namespace HotelExcellence.Telas.Nv3.listagem.Modals
{
    public partial class editeDepartamento : Form
    {
        int ID = 0;
        DepartamentoBLL dBLL = new DepartamentoBLL();
        DepartamentoDAO dDAO = new DepartamentoDAO();
        public editeDepartamento()
        {
            InitializeComponent();
        }
        public editeDepartamento(int id): this()
        {
            ID = id;
            dBLL = dDAO.Pesquisa(id.ToString());
            txtDepartamento.Text = dBLL.Nome.ToString();

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool verificado = Verificacao();
            if (verificado == true)
            {
               // dBLL.Nome = txtDepartamento.Text.ToString();
                //dBLL.Id = ID;
                string sql = "UPDATE tbl_Departamento SET nome ='%"+ txtDepartamento.Text.ToString() + "%'  WHERE id =" + ID;
                bool sucess = dDAO.Update(sql);
                if (sucess == true)
                {
                    MessageBox.Show("Departamento alterado com sucesso!");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Para campo para ser preenchido");
            }
        }

        public bool Verificacao()
        {
            bool verificado = false;
            if (txtDepartamento.Text == "")
            {
                this.txtDepartamento.BorderColorIdle = Color.Red;
                verificado = false;
            }
            else
            {
                verificado = true;
            }
            return verificado;
        }
    }
}
