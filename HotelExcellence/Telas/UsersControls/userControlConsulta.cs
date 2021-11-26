using Banco;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HotelExcellence.Telas.Modals
{
    public partial class userControlConsulta : UserControl
    {
        Geral geral = new Geral();
        public userControlConsulta()
        {
            InitializeComponent();
        }

        #region VARIAVEIS PRIVETE
        private int id;
        private string nomeHospede;
        private string reserva;
        private decimal preco;
        private string nomeQuarto;
        private string cpf;
        private string data_nascimento;
        private string sexo;
        private string rg;
        private Image fotoQuarto;
        #endregion
        #region GET E SETS
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string NomeHospede
        {
            get { return nomeHospede; }
            set { nomeHospede = value; lblName.Text = value; }
        }

        public string Reserva
        {
            get { return reserva; }
            set { reserva = value; lblDataReserva.Text = "Reservado: "+ value; }
        }

        public string NomeQuarto
        {
            get { return nomeQuarto; }
            set { nomeQuarto = value; lblQuarto.Text = value; }
        }

        public decimal Preco
        {
            get { return preco; }
            set { preco = value; lblPreco.Text = "Valor: " + value.ToString(); }
        }
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; lblCPF.Text = "CPF: " + value; }
        }
        public string Rg
        {
            get { return rg; }
            set { rg = value; lblRG.Text = "RG: " + value; }
        }
        public string Nascimento
        {
            get { return data_nascimento; }
            set { data_nascimento = value; lblDataNascimento.Text = "Data de Nascimento: " + value; }
        }
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; lblSEXO.Text = "Sexo: " + value; }
        }
        public Image Foto
        {
            get { return fotoQuarto; }
            set { fotoQuarto = value; pictureBox1.Image = value; }
        }
        #endregion

        private void picExcluir_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM tbl_Reserva WHERE ID = "+ ID;
            bool delete = geral.Deletando(sql);
            if (delete)
            {
                //BuscaReservaFRM.Instance.Popular(Cpf.ToString());
                MessageBox.Show("Reserva excluido com sucesso", "", MessageBoxButtons.OK);
            }

        }
    }
}
