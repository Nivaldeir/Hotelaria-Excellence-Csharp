using Banco;
using Classes;
using HotelExcellence.Telas.Nv3.listagem.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelExcellence.Telas.Nv3.listagem
{
    public partial class listDepartamentoFRM3 : Form
    {
        DepartamentoBLL dBLL = new DepartamentoBLL();
        DepartamentoDAO dDAO = new DepartamentoDAO();
        public listDepartamentoFRM3()
        {
            InitializeComponent();
            atualizandoDepartamento();
           /* string sql = "SELECT D.id, D.nome, SUM(S.quantidade) AS quantidadeItens, SUM(E.preco) AS valorEstoque, COUNT(C.ID) AS quantidadeCargos, COUNT(F.ID) AS quantidadeFuncionario FROM tbl_Departamento AS D LEFT JOIN tbl_ServicoConsumo AS S ON S.ID = D.id LEFT JOIN tbl_Estoque AS E ON E.ID = S.ID_ESTOQUE LEFT JOIN tbl_Cargos AS C ON C.ID_Departamento = D.ID LEFT JOIN tbl_Funcionario AS F ON F.IDcargo = C.ID GROUP BY D.id, D.nome";
            DataTable dt = dDAO.BuscandoTudo(sql);
            dtgDepartamento.DataSource = dt;
            this.txtPesquisa.Select();*/
            DataGrid();
        }

        private void DataGrid()
        {
            dtgDepartamento.Columns["id"].HeaderText = "ID";
            dtgDepartamento.Columns["nome"].HeaderText = "Departamento";
            dtgDepartamento.Columns["quantidadeItens"].HeaderText = "Quantidade em estoque";
            dtgDepartamento.Columns["valorEstoque"].HeaderText = "Valor do Estoque";
            dtgDepartamento.Columns["quantidadeCargos"].HeaderText = "Cargos Existente";
            dtgDepartamento.Columns["quantidadeFuncionario"].HeaderText = "Quantidade de Funcionarios";

            dtgDepartamento.Columns["id"].Visible = false;

            dtgDepartamento.Columns["Icon"].DisplayIndex = 0;
            dtgDepartamento.Columns["nome"].DisplayIndex = 1;
            dtgDepartamento.Columns["quantidadeItens"].DisplayIndex = 2;
            dtgDepartamento.Columns["valorEstoque"].DisplayIndex = 3;
            dtgDepartamento.Columns["quantidadeCargos"].DisplayIndex = 4;
            dtgDepartamento.Columns["quantidadeFuncionario"].DisplayIndex = 5;
            dtgDepartamento.Columns["Editar"].DisplayIndex = 6;
        }

        private void txtPesquisa_TextChange(object sender, EventArgs e)
        {
            atualizandoDepartamento();
        }

        private void dtgDepartamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int RowIndex = e.RowIndex;
                dBLL.Id = int.Parse(dtgDepartamento.Rows[RowIndex].Cells["id"].Value.ToString());
            }
            catch (Exception)
            {

            }

            string colName = dtgDepartamento.Columns[e.ColumnIndex].Name;

            if (colName == "Editar")
            {
                //MessageBox.Show("Editar");
                using (var editeDepartamento = new editeDepartamento(dBLL.Id))
                {
                    editeDepartamento.ShowDialog();
                    atualizandoDepartamento();
                    //editeQuarto.Show();
                }
            }
        }
        private void atualizandoDepartamento() {
            string sql = "SELECT D.id, D.nome, SUM(S.quantidade) AS quantidadeItens, SUM(E.preco) AS valorEstoque, COUNT(C.ID) AS quantidadeCargos, COUNT(F.ID) AS quantidadeFuncionario FROM tbl_Departamento AS D LEFT JOIN tbl_ServicoConsumo AS S ON S.ID = D.id LEFT JOIN tbl_Estoque AS E ON E.ID = S.ID_ESTOQUE LEFT JOIN tbl_Cargos AS C ON C.ID_Departamento = D.ID LEFT JOIN tbl_Funcionario AS F ON F.IDcargo = C.ID WHERE D.nome LIKE '%" + txtPesquisa.Text + "%' GROUP BY D.id, D.nome ";
            DataTable dt = dDAO.BuscandoTudo(sql);
            dtgDepartamento.DataSource = dt;
        }
    }

}
