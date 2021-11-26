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

namespace HotelExcellence.Telas.Nv2.listagem.Modals
{
    public partial class editeFuncionario : Form
    {
        #region INSTANCIAMENTOS
        FuncionarioDAO fDAO = new FuncionarioDAO();
        FuncionarioBLL fBLL = new FuncionarioBLL();
        CargosBLL cBLL = new CargosBLL();
        CargosDAO cDAO = new CargosDAO();
        DepartamentoBLL dBLL = new DepartamentoBLL();
        DepartamentoDAO dDAO = new DepartamentoDAO();
        #endregion
        #region VARIAVEIS
        Bitmap bmp;
        #endregion

        public editeFuncionario()
        {
            InitializeComponent();
        }
        public editeFuncionario(int ID): this()
        {
            this.txtNomeFuncionario.Select();
            if (ID == 0)
            {
            }
            else
            {
                #region POPULANDO DEPARTAMENTO
                string sql = "SELECT * FROM tbl_Departamento";
                 DataTable dtDepartamento = dDAO.BuscandoTudo(sql);
                cbDepartamento.DataSource = dtDepartamento;
                cbDepartamento.DisplayMember = "id";
                cbDepartamento.DisplayMember = "nome";
                #endregion
                #region PEGANDO OS DADOS DO FUNCIONARIOS COM SEU ID PASSADO PELO FORMULARIO DE LISTFUNCIONARIO
                //sql = "SELECT D.nome AS Departamento, f.ID, f.foto, f.nome, f.status, f.cpf, f.data_nascimento, f.sexo, f.cidade, f.uf , f.cep, f.numero, f.complemento, f.bairro, f.naturalidade, f.celular, f.telefone, f.rg, f.endereco, c.cargo FROM tbl_Funcionario AS F JOIN tbl_Cargos AS C ON C.ID = F.IDcargo JOIN tbl_Departamento AS D ON D.id = C.ID_Departamento WHERE f.ID =" + ID;
                fBLL = fDAO.Search("SELECT D.nome AS Departamento, f.ID, f.foto, f.nome, f.status, f.cpf, f.data_nascimento, f.sexo, f.cidade, f.uf , f.cep, f.numero, f.complemento, f.bairro, f.naturalidade, f.celular, f.telefone, f.rg, f.endereco, c.cargo FROM tbl_Funcionario AS F JOIN tbl_Cargos AS C ON C.ID = F.IDcargo JOIN tbl_Departamento AS D ON D.id = C.ID_Departamento WHERE f.ID =" + ID);
                cbDepartamento.Text = fBLL.nomeDepartamento;

                #region PEGANDO O CARGO DO FUNCIONARIO E COLOCANDO NO COMBO BOX
                //string idDepartamento = cbDepartamento.Text.ToString();
                sql = "SELECT cargo, salario, Carga_horaria FROM tbl_Cargos WHERE n_permissao <=" + 2 /*informacoesUsuario.nPermissao*/ + " AND ID_Departamento =" + dBLL.Id.ToString();
                dBLL = dDAO.Pesquisa(sql);
                DataTable dtCargo = cDAO.BuscandoTudo(dBLL.Id.ToString());
                cbProfissao.DataSource = dtCargo;
                //cbProfissao.ValueMember = "id";
                cbProfissao.DisplayMember = "cargo";
                //cbProfissao. = fBLL.cargo.ToString();
                txtSalario.DataBindings.Add("text", dtCargo, "salario");
                txtCargarHoraria.DataBindings.Add("text", dtCargo, "carga_horaria");
                #endregion

                cbProfissao.DisplayMember = fBLL.Cargo;
                if (fBLL.Foto != null) {  
                    MemoryStream imagem = new MemoryStream((byte[])(fBLL.Foto));
                    picFuncionario.Image = Image.FromStream(imagem);
                }
               
                txtNomeFuncionario.Text = fBLL.Nome.ToString();
                txtCPF.Text = fBLL.Cpf;
                dtDate.Text = fBLL.dataNascimento.ToString("dd/MM/yyyy");
                cbSEXO.Text = fBLL.Sexo;
                txtCidade.Text = fBLL.Cidade;
                txtUF.Text = fBLL.Uf;
                txtCEP.Text = fBLL.Cep;
                txtNumero.Text = fBLL.Numero;
                txtComplemento.Text = fBLL.Complemento;
                txtBairro.Text = fBLL.Bairro;
                txtNaturalidade.Text = fBLL.Naturalidade;
                txtCelular.Text = fBLL.Celular;
                txtTelefone.Text = fBLL.Telefone;
                txtRG.Text = fBLL.Rg;
                txtEndereco.Text = fBLL.Endereco;
                cbStatus.Text = fBLL.Status;
                #endregion
            }
        }

        private void editeFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void AdicionarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG Files(*.jpg)|*jpg|PNG Files(*png)|*.png |ALLFiles(*.*)| *.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foto = dialog.FileName;
                bmp = new Bitmap(foto);
                picFuncionario.Image = bmp;
            }
        }
        private void cbDepartamento_Click(object sender, EventArgs e)
        {

            
        }

        private void cbDepartamento_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                string idDepartamento = cbDepartamento.Text.ToString();
                string sql = "SELECT id, nome FROM tbl_Departamento WHERE ID ='%" + idDepartamento + "%'";
                dBLL = dDAO.Pesquisa(sql);

                sql = "SELECT cargo, salario, Carga_horaria FROM tbl_Cargos WHERE n_permissao <=" + informacoesUsuario.nPermissao + " AND ID_Departamento =" + dBLL.Id.ToString();

                DataTable dtCargo = cDAO.BuscandoTudo(sql);
                cbProfissao.DataSource = dtCargo;
                cbProfissao.DisplayMember = "cargo";
                txtSalario.DataBindings.Add("text", dtCargo, "salario");
                txtCargarHoraria.DataBindings.Add("text", dtCargo, "carga_horaria");
            }
            catch (Exception)
            {
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                fBLL.Nome = txtNomeFuncionario.Text;
                fBLL.Cpf = txtCPF.Text;
                fBLL.dataNascimento = DateTime.Parse(dtDate.Text);
                fBLL.Sexo = cbSEXO.Text ;
                fBLL.Cidade = txtCidade.Text ;
                fBLL.Uf = txtUF.Text ;
                fBLL.Cep = txtCEP.Text ;
                fBLL.Numero = txtNumero.Text ;
                fBLL.Complemento = txtComplemento.Text;
                fBLL.Bairro = txtBairro.Text;
                fBLL.Naturalidade = txtNaturalidade.Text;
                fBLL.Celular = txtCelular.Text;
                fBLL.Telefone = txtTelefone.Text;
                fBLL.Rg = txtRG.Text;
                fBLL.Endereco = txtEndereco.Text;
                fBLL.Status = cbStatus.Text;
                fBLL.nomeDepartamento = cbDepartamento.Text.ToString();

                cBLL = cDAO.Pesquisa("SELECT ID, salario FROM tbl_Cargos WHERE cargo LIKE '%" + cbProfissao.Text + "%'");
                fBLL.IDcargo = cBLL.Id;
                fBLL.Status = cbStatus.Text;
                fBLL.Sexo = cbSEXO.Text;
                MemoryStream memory = new MemoryStream();
                    
                if (memory == null)
                {
                fBLL.Foto = fBLL.Foto;
                }
                else
                {
                    bmp.Save(memory, ImageFormat.Bmp);
                    fBLL.Foto = memory.ToArray();
                }
            }
            catch (Exception)
            {

                throw;
            }


            if (fBLL.Id != 0)
            {
                bool sucess = fDAO.Update(fBLL);
                if (sucess == true)
                {
                    //listFuncionario.Instance.Popular("");
                    string msg = "Salvo com sucesso";
                    using (var Add = new Adicionado(msg))
                    {
                            
                        Add.ShowDialog();
                    }
                    this.Hide();

                }
            }
            if (fBLL.Id == 0)
            {
                bool sucess = fDAO.Insert(fBLL);
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
