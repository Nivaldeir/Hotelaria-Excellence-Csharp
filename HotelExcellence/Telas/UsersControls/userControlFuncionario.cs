using Banco;
using HotelExcellence.Telas.Nv2.listagem;
using HotelExcellence.Telas.Nv2.listagem.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelExcellence.Telas.Modals
{
    public partial class userControlFuncionario : UserControl
    {
        #region INSTANCIAMENTOS
        FuncionarioDAO fDAO = new FuncionarioDAO();
        #endregion
        public userControlFuncionario()
        {
            InitializeComponent();
        }
        #region VARIAVEIS PRIVETE
        private int id;
        private string nome;
        private string status;
        private string cpf;
        private string data_nascimento;
        private string sexo;
        private string cidade;
        private string uf;
        private string cep;
        private string numero;
        private string complemento;
        private string bairro;
        private string naturalidade;
        private string celular;
        private string telefone;
        private string rg;
        private string endereco;
        private string cargo;
        private string departamento;
        private Image foto;
        #endregion
        #region GET E SETS
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; lblnome.Text = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; lblStatus.Text = "Situação: " + value; }
        }
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; lblCpf.Text = "CPF: " + value; }
        }
        public string Rg
        {
            get { return rg; }
            set { rg = value; lblRG.Text = "RG: " + value; }
        }
        public string Nascimento
        {
            get { return data_nascimento; }
            set { data_nascimento = value; lblDate.Text = "Data de Nascimento: " + value; }
        }
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; lblSexo.Text = "Sexo: " + value; }
        }
        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; lblCargo.Text = "Cargo: " + value; }
        }
        public string Departamento
        {
            get { return departamento; }
            set { departamento = value; lblDepartamento.Text = "Departamento: " + value; }
        }
        public string Celular
        {
            get { return celular; }
            set { celular = value; lblCelular.Text = "Celular: " + value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; lblTelefone.Text = "Telefone: " + value; }
        }
        public string Cep
        {
            get { return cep; }
            set { cep = value; lblCEP.Text = "CEP: " + value; }
        }
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; lblCidade.Text = "Cidade: " + value; }
        }
        public string Uf
        {
            get { return uf; }
            set { uf = value; lblUF.Text = "UF: " + value; }
        }
        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; lblcomplemento.Text = "Complemento: " + value; }
        }
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; lblBairro.Text = "Bairro: " + value; }
        }
        public string Numero
        {
            get { return numero; }
            set { numero = value; lblNumero.Text = "Numero: " + value; }
        }
        public string Naturalidade
        {
            get { return naturalidade; }
            set { naturalidade = value; lblNaturalidade.Text = "Naturalidade: " + value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; lblEndereco.Text ="Endereço: " + value; }
        }
        public Image Foto
        {
            get { return foto; }
            set { foto = value; picFuncionario.Image = value; }
        }
        #endregion

        private void UserControlFuncionario_MouseEnter(object sender, EventArgs e)
        {
            if (Status == "Ativo")
            {
                Card.ShadowColor = Color.Green;
            }else if (Status == "Desligado")
            {
                Card.ShadowColor = Color.Red;
            }else if(Status == "Suspenso")
            {
                Card.ShadowColor = Color.Yellow;
            }
            

        }

        private void UserControlFuncionario_MouseLeave(object sender, EventArgs e)
        {
            Card.ShadowColor = Color.Gray;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM tbl_Login WHERE ID_FUNCIONARIO =" + ID + 
                "DELETE FROM tbl_Funcionario WHERE ID = " + ID;
            if (MessageBox.Show("Deseja excluir o cadastro", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bool sucess = fDAO.Deletando(sql);
                if (sucess)
                {
                    MessageBox.Show("Funcionario excluido com sucesso!");
                    listFuncionario.Instance.Popular("");
                }
                
            }
        }

        private void Card_Click(object sender, EventArgs e)
        {
            using (var editeFuncionario = new editeFuncionario(ID))
            {
                editeFuncionario.ShowDialog();
                //listQuarto.Instance.Popular(null);
            }
        }
    }
}
