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

namespace HotelExcellence.Telas.Nv3.cadastros
{
    public partial class cadCargoFRM3 : Form
    {
        #region INSTANCIAR
        CargosBLL cBLL = new CargosBLL();
        CargosDAO cDAO = new CargosDAO();
        DepartamentoDAO dDAO = new DepartamentoDAO();
        DepartamentoBLL dBLL = new DepartamentoBLL();
       
        #endregion
        public cadCargoFRM3()
        {
           
            InitializeComponent();
            buscaDepartamento();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool verificado = Verificar();
            if (verificado == true)
            {
                try
                {
                    if (int.Parse(txtNPermisao.Text) == 1 || int.Parse(txtNPermisao.Text) == 2 || int.Parse(txtNPermisao.Text) == 3)
                    {
                        cBLL.CargaHoraria = txtCargaHoraria.Text.ToString();
                        cBLL.Salario = decimal.Parse(txtSalario.Text.ToString());
                        cBLL.NivelPermissao= int.Parse(txtNPermisao.Text.ToString());
                        cBLL.Cargo = txtCargo.Text.ToString();
                        dBLL = dDAO.Pesquisa(cbDepartamento.Text);
                        cBLL.IdDepartamento = dBLL.Id;
                        string sql = "INSERT INTO tbl_Cargos(cargo, salario, Carga_horaria, n_permissao, ID_Departamento) VALUES ('%"+ txtCargo.Text.ToString()+"%', '%"+ decimal.Parse(txtSalario.Text.ToString()) + "%', '%" + txtCargaHoraria.Text.ToString() + "%', '%"+ int.Parse(txtNPermisao.Text.ToString()) + "%'," + cBLL.IdDepartamento + ")";

                        bool insert = cDAO.Insert(sql);
                        if (insert == true)
                        {
                            MessageBox.Show("Cargo cadastrado com sucesso");
                            Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nivel de permissão não registrado em nosso sistema", "", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }  
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar o cargo", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private bool Verificar()
        {
            bool verificado = false;
            if (txtSalario.Text == "" || txtNPermisao.Text == "" || txtCargo.Text == "" || txtCargaHoraria.Text == "")
            {
                if (txtCargaHoraria.Text == "")
                {
                    this.txtCargaHoraria.BorderColorDisabled = Color.Red;
                }

                if (txtCargo.Text == "")
                {
                    this.txtCargo.BorderColorDisabled = Color.Red;
                }

                if (txtNPermisao.Text == "")
                {
                    this.txtNPermisao.BorderColorDisabled = Color.Red;
                }
                if (txtSalario.Text == "")
                {
                    this.txtSalario.BorderColorDisabled = Color.Red;
                }
               
            }
            else
            {
                verificado = true;
            }

            return verificado;
        }
        public void Clear()
        {
            txtCargaHoraria.Clear();
            txtCargo.Clear();
            txtNPermisao.Clear();
            txtSalario.Clear();
            txtCargo.Focus();
        }

        private void cadCargoFRM3_Load(object sender, EventArgs e)
        {
            buscaDepartamento();
        }
        private void cbDepartamento_DataSourceChanged(object sender, EventArgs e)
        {
        }
        private void txtNPermisao_TextChanged(object sender, EventArgs e)
        {

        }
        private void cbDepartamento_MouseClick(object sender, MouseEventArgs e)
        {
            buscaDepartamento();
        }

        private void buscaDepartamento() {
            DataTable dtDepartamento = dDAO.BuscandoTudo("SELECT * FROM tbl_Departamento");
            cbDepartamento.DataSource = dtDepartamento;
            cbDepartamento.DisplayMember = "nome";
            cbDepartamento.ValueMember = "nome";
        }
    }
}
