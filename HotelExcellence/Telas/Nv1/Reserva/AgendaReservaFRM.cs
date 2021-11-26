using Banco;
using Classes;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Panel = System.Windows.Forms.Panel;

namespace HotelExcellence.Telas.Nv1
{
    public partial class AgendaReservaFRM : Form
    {
        #region INSTANCIAS
        ReservaBLL rBLL = new ReservaBLL();
        ReservaDAO rDAO = new ReservaDAO();
        QuartosBLL qBLL = new QuartosBLL();
        QuartosDAO qDAO = new QuartosDAO();
        #endregion
        #region VARIAVEIS
        Color Ocupado = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
        Color Disponivel = Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
        decimal valortotalCompra = 0;
        string entrada = "";
        #endregion
        public AgendaReservaFRM()
        {
            InitializeComponent();
            populandoComboBoxQuarto();
            /*Pegando o mes atual e o ano e selecionando no combo box*/
            #region Pegando o mes atual e o ano e selecionando no combo box
            cbMes.Text = DateTime.Now.ToString("MM");
            cbAno.Text = DateTime.Now.ToString("yyyy");
            #endregion

            AnoMes();
        }
        private void reservaQuartoFRM_Load(object sender, EventArgs e)
        {
            pnlDisponivel.BackgroundColor = Disponivel;
            pnlOcupado.BackgroundColor = Ocupado;
            DataGrid();
            EnableDay();

        }/* CARREGAMENTO DO FORMULARIO*/
        private void cbMes_SelectedValueChanged(object sender, EventArgs e)
        {
            AnoMes();
            VerificacaoMes();
            Calender();

        }/* PEGANDO O VALOR DO COMBO BOX DO MÊS*/
        private void panel1_Click(object sender, EventArgs e)
        {
            Panel panel = default(Panel);
            panel = (Panel)sender;
            int day = 0, mes = 0, ano = 0;
            try
            {
                mes = int.Parse(cbMes.Text);
                ano = int.Parse(cbAno.Text);
                if (mes >= int.Parse(DateTime.Now.ToString("MM")) && ano >= int.Parse(DateTime.Now.ToString("yyyy")))
                {

                    switch (panel.Name)
                    {
                        #region Quantidade de panel que representa os dias dos meses
                        case "panel1":
                            day = 01;
                            entrada = ano + "-" + mes + "-" + day;
                            Carrinho(DateTime.Parse(entrada));
                            break;

                        case "panel2":
                            day = 02;
                            entrada = ano + "-" + mes + "-" + day;
                            Carrinho(DateTime.Parse(entrada));
                            break;

                        case "panel3":
                            day = 03;
                            entrada = ano + "-" + mes + "-" + day;
                            Carrinho(DateTime.Parse(entrada));
                            break;

                        case "panel4":
                            day = 04;
                            entrada = ano + "-" + mes + "-" + day;
                            Carrinho(DateTime.Parse(entrada));
                            break;

                        case "panel5":
                            day = 05;
                            entrada = ano + "-" + mes + "-" + day;
                            Carrinho(DateTime.Parse(entrada));
                            break;

                        case "panel6":
                            day = 06;
                            entrada = ano + "-" + mes + "-" + day;
                            Carrinho(DateTime.Parse(entrada));
                            break;

                        case "panel7":
                            day = 07;
                            entrada = ano + "-" + mes + "-" + day;
                            Carrinho(DateTime.Parse(entrada));
                            break;

                        case "panel8":
                            day = 08;
                            entrada = ano + "-" + mes + "-" + day;
                            Carrinho(DateTime.Parse(entrada));
                            break;

                        case "panel9":
                            day = 09;
                            entrada = ano + "-" + mes + "-" + day;
                            Carrinho(DateTime.Parse(entrada));
                            break;

                        case "panel10":
                            day = 10;
                            entrada = ano + "-" + mes + "-" + day;
                            Carrinho(DateTime.Parse(entrada));
                            break;

                        case "panel11":
                            day = 11;
                            entrada = ano + "-" + mes + "-" + day;
                            Carrinho(DateTime.Parse(entrada));
                            break;

                        case "panel12":
                            day = 12;
                            entrada = ano + "-" + mes + "-" + day;
                            Carrinho(DateTime.Parse(entrada));
                            break;

                        case "panel13":
                            day = 13;
                            entrada = ano + "-" + mes + "-" + day;
                            Carrinho(DateTime.Parse(entrada));
                            break;

                        case "panel14":
                            day = 14;
                            entrada = ano + "-" + mes + "-" + day;
                            Carrinho(DateTime.Parse(entrada));
                            break;

                        case "panel15":
                            day = 15;
                            entrada = ano + "-" + mes + "-" + day;
                            Carrinho(DateTime.Parse(entrada));
                            break;

                        case "panel16":
                            day = 16;
                            entrada = ano + "-" + mes + "-" + day;
                            Carrinho(DateTime.Parse(entrada));
                            break;

                        case "panel17":
                            day = 17;
                            entrada = ano + "-" + mes + "-" + day;
                            Carrinho(DateTime.Parse(entrada));
                            break;

                        case "panel18":
                            day = 18;
                            entrada = ano + "-" + mes + "-" + day;
                            Carrinho(DateTime.Parse(entrada));
                            break;

                        case "panel19":
                            day = 19;
                            entrada = ano + "-" + mes + "-" + day;
                            Carrinho(DateTime.Parse(entrada));
                            break;

                        case "panel20":
                            day = 20;
                            entrada = ano + "-" + mes + "-" + day;
                            Carrinho(DateTime.Parse(entrada));
                            break;

                        case "panel21":
                            day = 21;
                            entrada = ano + "-" + mes + "-" + day;
                            Carrinho(DateTime.Parse(entrada));
                            break;

                        case "panel22":
                            day = 22;
                            entrada = ano + "-" + mes + "-" + day;
                            Carrinho(DateTime.Parse(entrada));
                            break;

                        case "panel23":
                            day = 23;
                            entrada = ano + "-" + mes + "-" + day;
                            Carrinho(DateTime.Parse(entrada));
                            break;

                        case "panel24":
                            day = 24;
                            entrada = ano + "-" + mes + "-" + day;
                            Carrinho(DateTime.Parse(entrada));
                            break;

                        case "panel25":
                            day = 25;
                            entrada = ano + "-" + mes + "-" + day;
                            Carrinho(DateTime.Parse(entrada));
                            break;

                        case "panel26":
                            day = 26;
                            entrada = ano + "-" + mes + "-" + day;
                            Carrinho(DateTime.Parse(entrada));
                            break;

                        case "panel27":
                            day = 27;
                            entrada = ano + "-" + mes + "-" + day;
                            Carrinho(DateTime.Parse(entrada));
                            break;

                        case "panel28":
                            day = 28;
                            entrada = ano + "-" + mes + "-" + day;
                            Carrinho(DateTime.Parse(entrada));
                            break;

                        case "panel29":
                            day = 29;
                            entrada = ano + "-" + mes + "-" + day;
                            Carrinho(DateTime.Parse(entrada));
                            break;

                        case "panel30":
                            day = 30;
                            entrada = ano + "-" + mes + "-" + day;
                            Carrinho(DateTime.Parse(entrada));
                            break;

                        case "panel31":
                            day = 31;
                            entrada = ano + "-" + mes + "-" + day;
                            Carrinho(DateTime.Parse(entrada));
                            break;
                            #endregion
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }/* VERIFICANDO QUAL DIA FOI CLICKADO PARA ADICIONAR NO DATAGRID*/
        #region Funcoes
        private void Carrinho(DateTime data)
        {
            string sql = "SELECT  ID, nome, subtitulo, descricao, qtd_cama, qtd_banheiro, qtd_tv, preco, numero, foto FROM tbl_Quarto WHERE nome LIKE '%" + cbQuarto.Text + "%'";
            qBLL = qDAO.Search(sql);
            qBLL.Foto = null;
            decimal valorTotal = qBLL.Preco * decimal.Parse(txtQuantidadee.Text);
            for (int i = 0; i < dtReserva.Rows.Count; i++)
            {
                if (qBLL.Nome == dtReserva.Rows[i].Cells[1].Value.ToString())
                {
                    if (data.ToString("dd/MM/yyyy") == dtReserva.Rows[i].Cells[3].Value.ToString())
                    {
                        MessageBox.Show("Data já reservada");
                        return;
                    }
                }
            }
            dtReserva.Rows.Add(qBLL.Id, qBLL.Nome, qBLL.Preco, data.ToString("dd/MM/yyyy"));
            valortotalCompra = valortotalCompra + valorTotal;

            lblTotal.Text = "Total: " + valortotalCompra;
        }  /* PEGANDO O QUARTO, QUANTIDADE, A DATA DE CHECKIN E COLOCANDO NO DATAGRID*/
        private void Calender()
        {
            CalenterClear();
            EnableDay();
            string sql = "SELECT r.ID, r.reserva, Q.nome FROM tbl_Reserva AS R JOIN tbl_Quarto AS Q ON Q.ID = R.ID_QUARTO WHERE Q.nome = '" + cbQuarto.Text + "'";
            DataTable dtReservaBanco = rDAO.BuscandoTudo(sql);
            for (int i = 0; i < dtReservaBanco.Rows.Count; i++)
            {
                int ID = Convert.ToInt32(dtReservaBanco.Rows[i]["ID"].ToString());
                sql = "SELECT R.ID, R.reserva, Q.nome AS Quarto FROM tbl_Reserva AS R JOIN tbl_Quarto AS Q ON Q.ID = R.ID_QUARTO WHERE R.ID =" + ID;
                rBLL = rDAO.buscarReserva(sql);
                string anoReserva = rBLL.Reserva.ToString("yyyy");
                string diaReserva = rBLL.Reserva.ToString("dd");
                string mesReserva = rBLL.Reserva.ToString("MM");
                if (anoReserva == cbAno.Text)
                {
                    if (cbMes.Text.Trim() == mesReserva)
                    {
                        if (diaReserva == "01")
                        {
                            lbl01.Text = "Dia 1";
                            panel1.BackgroundColor = Ocupado;
                            panel1.Enabled = false;
                        }

                        if (diaReserva == "02")
                        {
                            lbl02.Text = "Dia 2";
                            panel2.BackgroundColor = Ocupado;
                            panel2.Enabled = false;
                        }

                        if (diaReserva == "03")
                        {
                            lbl03.Text = "Dia 3";
                            panel3.BackgroundColor = Ocupado;
                            panel3.Enabled = false;
                        }

                        if (diaReserva == "04")
                        {
                            lbl04.Text = "Dia 04";
                            panel4.BackgroundColor = Ocupado;
                            panel4.Enabled = false;
                        }

                        if (diaReserva == "05")
                        {
                            lbl05.Text = "Dia 05";
                            panel5.BackgroundColor = Ocupado;
                            panel5.Enabled = false;
                        }

                        if (diaReserva == "06")
                        {
                            lbl06.Text = "Dia 6";
                            panel6.BackgroundColor = Ocupado;
                            panel6.Enabled = false;
                        }

                        if (diaReserva == "07")
                        {
                            lbl07.Text = "Dia 07";
                            panel7.BackgroundColor = Ocupado;
                            panel7.Enabled = false;
                        }

                        if (diaReserva == "08")
                        {
                            lbl08.Text = "Dia 08";
                            panel8.BackgroundColor = Ocupado;
                            panel8.Enabled = false;
                        }

                        if (diaReserva == "09")
                        {
                            lbl09.Text = "Dia 09";
                            panel9.BackgroundColor = Ocupado;
                            panel9.Enabled = false;
                        }

                        if (diaReserva == "10")
                        {
                            lbl010.Text = "Dia 10";
                            panel10.BackgroundColor = Ocupado;
                            panel10.Enabled = false;
                        }

                        if (diaReserva == "11")
                        {
                            lbl11.Text = "Dia 11";
                            panel11.BackgroundColor = Ocupado;
                            panel11.Enabled = false;
                        }

                        if (diaReserva == "12")
                        {
                            lbl12.Text = "Dia 12";
                            panel12.BackgroundColor = Ocupado;
                            panel12.Enabled = false;
                        }
                        if (diaReserva == "13")
                        {
                            lbl13.Text = "Dia 13";
                            panel13.BackgroundColor = Ocupado;
                            panel13.Enabled = false;
                        }

                        if (diaReserva == "14")
                        {
                            lbl14.Text = "Dia 14";
                            panel14.BackgroundColor = Ocupado;
                            panel14.Enabled = false;
                        }

                        if (diaReserva == "15")
                        {
                            lbl15.Text = "Dia 15";
                            panel15.BackgroundColor = Ocupado;
                            panel15.Enabled = false;
                        }

                        if (diaReserva == "16")
                        {
                            lbl16.Text = "Dia 16";
                            panel6.BackgroundColor = Ocupado;
                            panel16.Enabled = false;
                        }

                        if (diaReserva == "17")
                        {
                            lbl17.Text = "Dia 17";
                            panel17.BackgroundColor = Ocupado;
                            panel17.Enabled = false;
                        }


                        if (diaReserva == "18")
                        {
                            lbl18.Text = "Dia 18";
                            panel18.BackgroundColor = Ocupado;
                            panel18.Enabled = false;
                        }

                        if (diaReserva == "19")
                        {
                            lbl19.Text = "Dia 19";
                            panel9.BackgroundColor = Ocupado;
                            panel19.Enabled = false;
                        }

                        if (diaReserva == "20")
                        {
                            lbl20.Text = "Dia 20";
                            panel20.BackgroundColor = Ocupado;
                            panel20.Enabled = false;
                        }

                        if (diaReserva == "21")
                        {
                            lbl21.Text = "Dia 21";
                            panel21.BackgroundColor = Ocupado;
                            panel21.Enabled = false;
                        }
                        if (diaReserva == "22")
                        {
                            lbl22.Text = "Dia 22";
                            panel22.BackgroundColor = Ocupado;
                            panel22.Enabled = false;
                        }


                        if (diaReserva == "23")
                        {
                            lbl23.Text = "Dia 23";
                            panel23.BackgroundColor = Ocupado;
                            panel23.Enabled = false;
                        }
                        if (diaReserva == "24")
                        {
                            lbl24.Text = "Dia 24";
                            panel24.BackgroundColor = Ocupado;
                            panel24.Enabled = false;

                        }
                        if (diaReserva == "25")
                        {
                            lbl25.Text = "Dia 25";
                            panel25.BackgroundColor = Ocupado;
                            panel25.Enabled = false;
                        }
                        if (diaReserva == "26")
                        {
                            lbl26.Text = "Dia 26";
                            panel26.BackgroundColor = Ocupado;
                            panel26.Enabled = false;
                        }
                        if (diaReserva == "27")
                        {
                            lbl27.Text = "Dia 27";
                            panel27.BackgroundColor = Ocupado;
                            panel27.Enabled = false;
                        }
                        if (diaReserva == "28")
                        {
                            lbl28.Text = "Dia 28";
                            panel28.BackgroundColor = Ocupado;
                            panel28.Enabled = false;
                        }
                        if (diaReserva == "29")
                        {
                            lbl29.Text = "Dia 29";
                            panel29.BackgroundColor = Ocupado;
                            panel29.Enabled = false;
                        }
                        if (diaReserva == "30")
                        {
                            lbl30.Text = "Dia 30";
                            panel30.BackgroundColor = Ocupado;
                            panel30.Enabled = false;
                        }
                        if (diaReserva == "31")
                        {
                            lbl31.Text = "Dia 31";
                            panel31.BackgroundColor = Ocupado;
                            panel31.Enabled = false;
                        }
                    }
                }
            }
            //dtReservaBanco.Clear();
        } /* BUSCANDO NO BANCO DE DADOS AS RESERVAS DO QUARTO SELECIONADO NO COMBO BOX*/
        private void VerificacaoMes()
        {
            if (cbMes.Text == "12")
            {
                panel30.Visible = true;
                panel29.Visible = true;
                panel31.Visible = true;
            }

            if (cbMes.Text == "01")
            {
                panel31.Visible = true;
                panel30.Visible = true;
                panel29.Visible = true;
            }

            if (cbMes.Text == "02")
            {
                panel31.Visible = false;
                panel30.Visible = false;
                panel29.Visible = false;
            }
            if (cbMes.Text == "03")
            {
                panel31.Visible = true;
                panel30.Visible = true;
                panel29.Visible = true;
            }

            if (cbMes.Text == "04")
            {
                panel31.Visible = false;
                panel30.Visible = true;
                panel29.Visible = true;
            }
            if (cbMes.Text == "05")
            {
                panel31.Visible = true;
                panel30.Visible = true;
                panel29.Visible = true;
            }
            if (cbMes.Text == "06")
            {
                panel31.Visible = false;
                panel30.Visible = true;
                panel29.Visible = true;
            }
            if (cbMes.Text == "07")
            {
                panel31.Visible = true;
                panel30.Visible = true;
                panel29.Visible = true;
            }
            if (cbMes.Text == "08")
            {
                panel31.Visible = true;
                panel30.Visible = true;
                panel29.Visible = true;
            }
            if (cbMes.Text == "09")
            {
                panel31.Visible = false;
                panel30.Visible = true;
                panel29.Visible = true;
            }
            if (cbMes.Text == "10")
            {
                panel31.Visible = true;
                panel30.Visible = true;
                panel29.Visible = true;
            }
            if (cbMes.Text == "11")
            {
                panel31.Visible = false;
                panel30.Visible = true;
                panel29.Visible = true;
            }
        } /* VERIFICANDO O MES PARA CONTABILIDADE DOS DIAS*/
        private void CalenterClear()
        {
            #region Background Color disponivel
            panel1.BackgroundColor = Disponivel;
            panel2.BackgroundColor = Disponivel;
            panel3.BackgroundColor = Disponivel;
            panel4.BackgroundColor = Disponivel;
            panel5.BackgroundColor = Disponivel;
            panel6.BackgroundColor = Disponivel;
            panel7.BackgroundColor = Disponivel;
            panel8.BackgroundColor = Disponivel;
            panel9.BackgroundColor = Disponivel;
            panel10.BackgroundColor = Disponivel;
            panel11.BackgroundColor = Disponivel;
            panel12.BackgroundColor = Disponivel;
            panel13.BackgroundColor = Disponivel;
            panel14.BackgroundColor = Disponivel;
            panel15.BackgroundColor = Disponivel;
            panel16.BackgroundColor = Disponivel;
            panel17.BackgroundColor = Disponivel;
            panel18.BackgroundColor = Disponivel;
            panel19.BackgroundColor = Disponivel;
            panel20.BackgroundColor = Disponivel;
            panel21.BackgroundColor = Disponivel;
            panel22.BackgroundColor = Disponivel;
            panel23.BackgroundColor = Disponivel;
            panel24.BackgroundColor = Disponivel;
            panel25.BackgroundColor = Disponivel;
            panel26.BackgroundColor = Disponivel;
            panel27.BackgroundColor = Disponivel;
            panel28.BackgroundColor = Disponivel;
            panel29.BackgroundColor = Disponivel;
            panel30.BackgroundColor = Disponivel;
            panel31.BackgroundColor = Disponivel;
            #endregion
            #region Panel Ativado
            panel1.Enabled = true;
            panel2.Enabled = true;
            panel3.Enabled = true;
            panel4.Enabled = true;
            panel5.Enabled = true;
            panel6.Enabled = true;
            panel7.Enabled = true;
            panel8.Enabled = true;
            panel9.Enabled = true;
            panel10.Enabled = true;
            panel11.Enabled = true;
            panel12.Enabled = true;
            panel13.Enabled = true;
            panel14.Enabled = true;
            panel15.Enabled = true;
            panel16.Enabled = true;
            panel17.Enabled = true;
            panel18.Enabled = true;
            panel19.Enabled = true;
            panel20.Enabled = true;
            panel21.Enabled = true;
            panel22.Enabled = true;
            panel23.Enabled = true;
            panel24.Enabled = true;
            panel25.Enabled = true;
            panel26.Enabled = true;
            panel27.Enabled = true;
            panel28.Enabled = true;
            panel29.Enabled = true;
            panel30.Enabled = true;
            panel31.Enabled = true;
            #endregion

        } /* LIMPANDO O CALENDARIO*/
        private void DataGrid()
        {
            dtReserva.ColumnCount = 6;
            dtReserva.Columns[0].Name = "Código";
            dtReserva.Columns[0].Visible = false;
            dtReserva.Columns[1].HeaderText = "Quarto";

            dtReserva.Columns[2].HeaderText = "Valor Diaria";
            dtReserva.Columns[2].DefaultCellStyle.Format = "c";
            dtReserva.Columns[3].HeaderText = "Data da Reserva";
            dtReserva.Columns[3].DefaultCellStyle.Format = "c";

            dtReserva.Columns[1].Width = 200;
            dtReserva.Columns[2].Width = 150;
            dtReserva.Columns[3].Width = 150;


            dtReserva.Columns[0].DisplayIndex = 0;
            dtReserva.Columns[1].DisplayIndex = 1;
            dtReserva.Columns[2].DisplayIndex = 2;
            dtReserva.Columns[3].DisplayIndex = 3;
        }/* RENOMEANDO O DATAGRID*/
        private void EnableDay()
        {
            int day = int.Parse(DateTime.Now.ToString("dd"));
            int ano = int.Parse(DateTime.Now.ToString("yyyy"));
            int mes = int.Parse(DateTime.Now.ToString("MM"));
            try
            {
                if (int.Parse(cbAno.Text) < ano)
                {
                    #region Panel Ativado
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    panel4.Enabled = false;
                    panel5.Enabled = false;
                    panel6.Enabled = false;
                    panel7.Enabled = false;
                    panel8.Enabled = false;
                    panel9.Enabled = false;
                    panel10.Enabled = false;
                    panel11.Enabled = false;
                    panel12.Enabled = false;
                    panel13.Enabled = false;
                    panel14.Enabled = false;
                    panel15.Enabled = false;
                    panel16.Enabled = false;
                    panel17.Enabled = false;
                    panel18.Enabled = false;
                    panel19.Enabled = false;
                    panel20.Enabled = false;
                    panel21.Enabled = false;
                    panel22.Enabled = false;
                    panel23.Enabled = false;
                    panel24.Enabled = false;
                    panel25.Enabled = false;
                    panel26.Enabled = false;
                    panel27.Enabled = false;
                    panel28.Enabled = false;
                    panel29.Enabled = false;
                    panel30.Enabled = false;
                    panel31.Enabled = false;
                    #endregion
                }
                else if (int.Parse(cbAno.Text) == ano && int.Parse(cbMes.Text) < mes)
                {
                    #region Panel Ativado
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                    panel4.Enabled = false;
                    panel5.Enabled = false;
                    panel6.Enabled = false;
                    panel7.Enabled = false;
                    panel8.Enabled = false;
                    panel9.Enabled = false;
                    panel10.Enabled = false;
                    panel11.Enabled = false;
                    panel12.Enabled = false;
                    panel13.Enabled = false;
                    panel14.Enabled = false;
                    panel15.Enabled = false;
                    panel16.Enabled = false;
                    panel17.Enabled = false;
                    panel18.Enabled = false;
                    panel19.Enabled = false;
                    panel20.Enabled = false;
                    panel21.Enabled = false;
                    panel22.Enabled = false;
                    panel23.Enabled = false;
                    panel24.Enabled = false;
                    panel25.Enabled = false;
                    panel26.Enabled = false;
                    panel27.Enabled = false;
                    panel28.Enabled = false;
                    panel29.Enabled = false;
                    panel30.Enabled = false;
                    panel31.Enabled = false;
                    #endregion
                }
                else if (int.Parse(cbAno.Text) == ano && int.Parse(cbMes.Text) == mes)
                {
                    switch (day)
                    {
                        case 01:

                            break;
                        case 02:
                            panel1.Enabled = false;
                            break;

                        case 03:
                            panel1.Enabled = false;
                            panel2.Enabled = false;
                            break;

                        case 04:
                            panel1.Enabled = false;
                            panel2.Enabled = false;
                            panel3.Enabled = false;
                            break;
                        case 05:
                            panel1.Enabled = false;
                            panel2.Enabled = false;
                            panel3.Enabled = false;
                            panel4.Enabled = false;
                            break;

                        case 06:
                            panel1.Enabled = false;
                            panel2.Enabled = false;
                            panel3.Enabled = false;
                            panel4.Enabled = false;
                            panel5.Enabled = false;
                            break;

                        case 07:
                            panel1.Enabled = false;
                            panel2.Enabled = false;
                            panel3.Enabled = false;
                            panel4.Enabled = false;
                            panel5.Enabled = false;
                            panel6.Enabled = false;
                            break;

                        case 08:
                            panel1.Enabled = false;
                            panel2.Enabled = false;
                            panel3.Enabled = false;
                            panel4.Enabled = false;
                            panel5.Enabled = false;
                            panel6.Enabled = false;
                            panel7.Enabled = false;
                            break;

                        case 09:
                            panel1.Enabled = false;
                            panel2.Enabled = false;
                            panel3.Enabled = false;
                            panel4.Enabled = false;
                            panel5.Enabled = false;
                            panel6.Enabled = false;
                            panel7.Enabled = false;
                            panel8.Enabled = false;
                            break;

                        case 10:
                            panel1.Enabled = false;
                            panel2.Enabled = false;
                            panel3.Enabled = false;
                            panel4.Enabled = false;
                            panel5.Enabled = false;
                            panel6.Enabled = false;
                            panel7.Enabled = false;
                            panel8.Enabled = false;
                            panel9.Enabled = false;
                            break;

                        case 11:
                            panel1.Enabled = false;
                            panel2.Enabled = false;
                            panel3.Enabled = false;
                            panel4.Enabled = false;
                            panel5.Enabled = false;
                            panel6.Enabled = false;
                            panel7.Enabled = false;
                            panel8.Enabled = false;
                            panel9.Enabled = false;
                            panel10.Enabled = false;
                            break;

                        case 12:
                            panel1.Enabled = false;
                            panel2.Enabled = false;
                            panel3.Enabled = false;
                            panel4.Enabled = false;
                            panel5.Enabled = false;
                            panel6.Enabled = false;
                            panel7.Enabled = false;
                            panel8.Enabled = false;
                            panel9.Enabled = false;
                            panel10.Enabled = false;
                            panel11.Enabled = false;

                            break;

                        case 13:
                            panel1.Enabled = false;
                            panel2.Enabled = false;
                            panel3.Enabled = false;
                            panel4.Enabled = false;
                            panel5.Enabled = false;
                            panel6.Enabled = false;
                            panel7.Enabled = false;
                            panel8.Enabled = false;
                            panel9.Enabled = false;
                            panel10.Enabled = false;
                            panel11.Enabled = false;
                            panel12.Enabled = false;
                            break;

                        case 14:
                            panel1.Enabled = false;
                            panel2.Enabled = false;
                            panel3.Enabled = false;
                            panel4.Enabled = false;
                            panel5.Enabled = false;
                            panel6.Enabled = false;
                            panel7.Enabled = false;
                            panel8.Enabled = false;
                            panel9.Enabled = false;
                            panel10.Enabled = false;
                            panel11.Enabled = false;
                            panel12.Enabled = false;
                            panel13.Enabled = false;
                            break;

                        case 15:
                            panel1.Enabled = false;
                            panel2.Enabled = false;
                            panel3.Enabled = false;
                            panel4.Enabled = false;
                            panel5.Enabled = false;
                            panel6.Enabled = false;
                            panel7.Enabled = false;
                            panel8.Enabled = false;
                            panel9.Enabled = false;
                            panel10.Enabled = false;
                            panel11.Enabled = false;
                            panel12.Enabled = false;
                            panel13.Enabled = false;
                            panel14.Enabled = false;
                            break;

                        case 16:
                            panel1.Enabled = false;
                            panel2.Enabled = false;
                            panel3.Enabled = false;
                            panel4.Enabled = false;
                            panel5.Enabled = false;
                            panel6.Enabled = false;
                            panel7.Enabled = false;
                            panel8.Enabled = false;
                            panel9.Enabled = false;
                            panel10.Enabled = false;
                            panel11.Enabled = false;
                            panel12.Enabled = false;
                            panel13.Enabled = false;
                            panel14.Enabled = false;
                            panel15.Enabled = false;
                            break;

                        case 17:
                            panel1.Enabled = false;
                            panel2.Enabled = false;
                            panel3.Enabled = false;
                            panel4.Enabled = false;
                            panel5.Enabled = false;
                            panel6.Enabled = false;
                            panel7.Enabled = false;
                            panel8.Enabled = false;
                            panel9.Enabled = false;
                            panel10.Enabled = false;
                            panel11.Enabled = false;
                            panel12.Enabled = false;
                            panel13.Enabled = false;
                            panel14.Enabled = false;
                            panel15.Enabled = false;
                            panel16.Enabled = false;
                            break;

                        case 18:
                            panel1.Enabled = false;
                            panel2.Enabled = false;
                            panel3.Enabled = false;
                            panel4.Enabled = false;
                            panel5.Enabled = false;
                            panel6.Enabled = false;
                            panel7.Enabled = false;
                            panel8.Enabled = false;
                            panel9.Enabled = false;
                            panel10.Enabled = false;
                            panel11.Enabled = false;
                            panel12.Enabled = false;
                            panel13.Enabled = false;
                            panel14.Enabled = false;
                            panel15.Enabled = false;
                            panel16.Enabled = false;
                            panel17.Enabled = false;
                            break;

                        case 19:
                            panel1.Enabled = false;
                            panel2.Enabled = false;
                            panel3.Enabled = false;
                            panel4.Enabled = false;
                            panel5.Enabled = false;
                            panel6.Enabled = false;
                            panel7.Enabled = false;
                            panel8.Enabled = false;
                            panel9.Enabled = false;
                            panel10.Enabled = false;
                            panel11.Enabled = false;
                            panel12.Enabled = false;
                            panel13.Enabled = false;
                            panel14.Enabled = false;
                            panel15.Enabled = false;
                            panel16.Enabled = false;
                            panel17.Enabled = false;
                            panel18.Enabled = false;
                            break;

                        case 20:
                            panel1.Enabled = false;
                            panel2.Enabled = false;
                            panel3.Enabled = false;
                            panel4.Enabled = false;
                            panel5.Enabled = false;
                            panel6.Enabled = false;
                            panel7.Enabled = false;
                            panel8.Enabled = false;
                            panel9.Enabled = false;
                            panel10.Enabled = false;
                            panel11.Enabled = false;
                            panel12.Enabled = false;
                            panel13.Enabled = false;
                            panel14.Enabled = false;
                            panel15.Enabled = false;
                            panel16.Enabled = false;
                            panel17.Enabled = false;
                            panel18.Enabled = false;
                            panel19.Enabled = false;
                            break;

                        case 21:
                            panel1.Enabled = false;
                            panel2.Enabled = false;
                            panel3.Enabled = false;
                            panel4.Enabled = false;
                            panel5.Enabled = false;
                            panel6.Enabled = false;
                            panel7.Enabled = false;
                            panel8.Enabled = false;
                            panel9.Enabled = false;
                            panel10.Enabled = false;
                            panel11.Enabled = false;
                            panel12.Enabled = false;
                            panel13.Enabled = false;
                            panel14.Enabled = false;
                            panel15.Enabled = false;
                            panel16.Enabled = false;
                            panel17.Enabled = false;
                            panel18.Enabled = false;
                            panel19.Enabled = false;
                            panel20.Enabled = false;
                            break;

                        case 22:
                            panel1.Enabled = false;
                            panel2.Enabled = false;
                            panel3.Enabled = false;
                            panel4.Enabled = false;
                            panel5.Enabled = false;
                            panel6.Enabled = false;
                            panel7.Enabled = false;
                            panel8.Enabled = false;
                            panel9.Enabled = false;
                            panel10.Enabled = false;
                            panel11.Enabled = false;
                            panel12.Enabled = false;
                            panel13.Enabled = false;
                            panel14.Enabled = false;
                            panel15.Enabled = false;
                            panel16.Enabled = false;
                            panel17.Enabled = false;
                            panel18.Enabled = false;
                            panel19.Enabled = false;
                            panel20.Enabled = false;
                            panel21.Enabled = false;
                            break;

                        case 23:
                            panel1.Enabled = false;
                            panel2.Enabled = false;
                            panel3.Enabled = false;
                            panel4.Enabled = false;
                            panel5.Enabled = false;
                            panel6.Enabled = false;
                            panel7.Enabled = false;
                            panel8.Enabled = false;
                            panel9.Enabled = false;
                            panel10.Enabled = false;
                            panel11.Enabled = false;
                            panel12.Enabled = false;
                            panel13.Enabled = false;
                            panel14.Enabled = false;
                            panel15.Enabled = false;
                            panel16.Enabled = false;
                            panel17.Enabled = false;
                            panel18.Enabled = false;
                            panel19.Enabled = false;
                            panel20.Enabled = false;
                            panel21.Enabled = false;
                            panel22.Enabled = false;
                            break;

                        case 24:
                            panel1.Enabled = false;
                            panel2.Enabled = false;
                            panel3.Enabled = false;
                            panel4.Enabled = false;
                            panel5.Enabled = false;
                            panel6.Enabled = false;
                            panel7.Enabled = false;
                            panel8.Enabled = false;
                            panel9.Enabled = false;
                            panel10.Enabled = false;
                            panel11.Enabled = false;
                            panel12.Enabled = false;
                            panel13.Enabled = false;
                            panel14.Enabled = false;
                            panel15.Enabled = false;
                            panel16.Enabled = false;
                            panel17.Enabled = false;
                            panel18.Enabled = false;
                            panel19.Enabled = false;
                            panel20.Enabled = false;
                            panel21.Enabled = false;
                            panel22.Enabled = false;
                            panel23.Enabled = false;
                            break;

                        case 25:
                            panel1.Enabled = false;
                            panel2.Enabled = false;
                            panel3.Enabled = false;
                            panel4.Enabled = false;
                            panel5.Enabled = false;
                            panel6.Enabled = false;
                            panel7.Enabled = false;
                            panel8.Enabled = false;
                            panel9.Enabled = false;
                            panel10.Enabled = false;
                            panel11.Enabled = false;
                            panel12.Enabled = false;
                            panel13.Enabled = false;
                            panel14.Enabled = false;
                            panel15.Enabled = false;
                            panel16.Enabled = false;
                            panel17.Enabled = false;
                            panel18.Enabled = false;
                            panel19.Enabled = false;
                            panel20.Enabled = false;
                            panel21.Enabled = false;
                            panel22.Enabled = false;
                            panel23.Enabled = false;
                            panel24.Enabled = false;
                            break;

                        case 26:
                            panel1.Enabled = false;
                            panel2.Enabled = false;
                            panel3.Enabled = false;
                            panel4.Enabled = false;
                            panel5.Enabled = false;
                            panel6.Enabled = false;
                            panel7.Enabled = false;
                            panel8.Enabled = false;
                            panel9.Enabled = false;
                            panel10.Enabled = false;
                            panel11.Enabled = false;
                            panel12.Enabled = false;
                            panel13.Enabled = false;
                            panel14.Enabled = false;
                            panel15.Enabled = false;
                            panel16.Enabled = false;
                            panel17.Enabled = false;
                            panel18.Enabled = false;
                            panel19.Enabled = false;
                            panel20.Enabled = false;
                            panel21.Enabled = false;
                            panel22.Enabled = false;
                            panel23.Enabled = false;
                            panel24.Enabled = false;
                            panel25.Enabled = false;
                            break;

                        case 27:
                            panel1.Enabled = false;
                            panel2.Enabled = false;
                            panel3.Enabled = false;
                            panel4.Enabled = false;
                            panel5.Enabled = false;
                            panel6.Enabled = false;
                            panel7.Enabled = false;
                            panel8.Enabled = false;
                            panel9.Enabled = false;
                            panel10.Enabled = false;
                            panel11.Enabled = false;
                            panel12.Enabled = false;
                            panel13.Enabled = false;
                            panel14.Enabled = false;
                            panel15.Enabled = false;
                            panel16.Enabled = false;
                            panel17.Enabled = false;
                            panel18.Enabled = false;
                            panel19.Enabled = false;
                            panel20.Enabled = false;
                            panel21.Enabled = false;
                            panel22.Enabled = false;
                            panel23.Enabled = false;
                            panel24.Enabled = false;
                            panel25.Enabled = false;
                            panel26.Enabled = false;
                            break;
                        case 28:
                            panel1.Enabled = false;
                            panel2.Enabled = false;
                            panel3.Enabled = false;
                            panel4.Enabled = false;
                            panel5.Enabled = false;
                            panel6.Enabled = false;
                            panel7.Enabled = false;
                            panel8.Enabled = false;
                            panel9.Enabled = false;
                            panel10.Enabled = false;
                            panel11.Enabled = false;
                            panel12.Enabled = false;
                            panel13.Enabled = false;
                            panel14.Enabled = false;
                            panel15.Enabled = false;
                            panel16.Enabled = false;
                            panel17.Enabled = false;
                            panel18.Enabled = false;
                            panel19.Enabled = false;
                            panel20.Enabled = false;
                            panel21.Enabled = false;
                            panel22.Enabled = false;
                            panel23.Enabled = false;
                            panel24.Enabled = false;
                            panel25.Enabled = false;
                            panel26.Enabled = false;
                            panel27.Enabled = false;
                            break;

                        case 29:
                            panel1.Enabled = false;
                            panel2.Enabled = false;
                            panel3.Enabled = false;
                            panel4.Enabled = false;
                            panel5.Enabled = false;
                            panel6.Enabled = false;
                            panel7.Enabled = false;
                            panel8.Enabled = false;
                            panel9.Enabled = false;
                            panel10.Enabled = false;
                            panel11.Enabled = false;
                            panel12.Enabled = false;
                            panel13.Enabled = false;
                            panel14.Enabled = false;
                            panel15.Enabled = false;
                            panel16.Enabled = false;
                            panel17.Enabled = false;
                            panel18.Enabled = false;
                            panel19.Enabled = false;
                            panel20.Enabled = false;
                            panel21.Enabled = false;
                            panel22.Enabled = false;
                            panel23.Enabled = false;
                            panel24.Enabled = false;
                            panel25.Enabled = false;
                            panel26.Enabled = false;
                            panel27.Enabled = false;
                            panel28.Enabled = false;
                            break;

                        case 30:
                            panel1.Enabled = false;
                            panel2.Enabled = false;
                            panel3.Enabled = false;
                            panel4.Enabled = false;
                            panel5.Enabled = false;
                            panel6.Enabled = false;
                            panel7.Enabled = false;
                            panel8.Enabled = false;
                            panel9.Enabled = false;
                            panel10.Enabled = false;
                            panel11.Enabled = false;
                            panel12.Enabled = false;
                            panel13.Enabled = false;
                            panel14.Enabled = false;
                            panel15.Enabled = false;
                            panel16.Enabled = false;
                            panel17.Enabled = false;
                            panel18.Enabled = false;
                            panel19.Enabled = false;
                            panel20.Enabled = false;
                            panel21.Enabled = false;
                            panel22.Enabled = false;
                            panel23.Enabled = false;
                            panel24.Enabled = false;
                            panel25.Enabled = false;
                            panel26.Enabled = false;
                            panel27.Enabled = false;
                            panel28.Enabled = false;
                            panel29.Enabled = false;
                            break;

                        case 31:
                            panel1.Enabled = false;
                            panel2.Enabled = false;
                            panel3.Enabled = false;
                            panel4.Enabled = false;
                            panel5.Enabled = false;
                            panel6.Enabled = false;
                            panel7.Enabled = false;
                            panel8.Enabled = false;
                            panel9.Enabled = false;
                            panel10.Enabled = false;
                            panel11.Enabled = false;
                            panel12.Enabled = false;
                            panel13.Enabled = false;
                            panel14.Enabled = false;
                            panel15.Enabled = false;
                            panel16.Enabled = false;
                            panel17.Enabled = false;
                            panel18.Enabled = false;
                            panel19.Enabled = false;
                            panel20.Enabled = false;
                            panel21.Enabled = false;
                            panel22.Enabled = false;
                            panel23.Enabled = false;
                            panel24.Enabled = false;
                            panel25.Enabled = false;
                            panel26.Enabled = false;
                            panel27.Enabled = false;
                            panel28.Enabled = false;
                            panel29.Enabled = false;
                            panel30.Enabled = false;
                            break;
                    }
                }
            }
            catch (Exception)
            {
            }
        } /* VALIDANDO OS DIAS. PARA RESERVAR APARTI DE HOJE*/
        private void AnoMes()
        {
            if (cbMes.Text == "")
            {
                cbMes.Text = DateTime.Now.ToString("MM");
            }
            if (cbAno.Text == "")
            {
                cbAno.Text = DateTime.Now.ToString("yyyy");
            }
            /*Pega o numero inserido pelo combo box e busca o nome o Mes e depois coloca o ano*/
            lblCalender.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(int.Parse(cbMes.Text.ToString())) + ", " + cbAno.Text;
            /*pega o label e transforma a primeira letra em Maisculo*/
            lblCalender.Text = char.ToUpper(lblCalender.Text[0]) + lblCalender.Text.Substring(1);
        } /* CONVERTENDO O NUMERO PARA O NOME DO MÊS*/
        #endregion

        #region Botoes
        private void btnRighCalender_Click(object sender, EventArgs e)
        {

            int i = int.Parse(cbMes.SelectedItem.ToString()) + 1;

            if (i.ToString().Length == 1)
            {
                cbMes.SelectedItem = "0" + i;
            }
            if (i == 12)
            {
                cbMes.SelectedIndex = 11;
            }
            else
            {
                cbMes.SelectedItem = i.ToString();
            }
            if (i == 13)
            {
                cbAno.SelectedIndex = cbAno.SelectedIndex + 1;
                cbMes.SelectedItem = "01";
            }
            AnoMes();
        }/* IR PARA O PROXIMO MÊS NO CALENDARIO*/
        private void btnADD_Click(object sender, EventArgs e)
        {
            if (cbpagamento.Text == "")
            {
                MessageBox.Show("Informar o meio de pagamento", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Deseja confirmar pagamento?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    PagamentoBLL pBLL = new PagamentoBLL();
                    PagamentoDAO pDAO = new PagamentoDAO();
                    pBLL.formaPagamento = cbpagamento.Text;
                    pBLL.Valor = valortotalCompra;
                    bool insertPgamaneto = pDAO.cadastrarPagamento(pBLL);
                    string sql = "SELECT COUNT(ID) AS ID FROM tbl_FormaPagamento";
                    DataTable dtPagamento = pDAO.BuscandoTudo(sql);
                    int j = 0;

                    int idPagamento = int.Parse(dtPagamento.Rows[j]["ID"].ToString());
                    for (int i = 0; i < dtReserva.Rows.Count; i++)
                    {

                        rBLL.idQuarto = int.Parse(dtReserva.Rows[i].Cells[0].Value.ToString());
                        rBLL.Reserva = DateTime.Parse(dtReserva.Rows[i].Cells[3].Value.ToString());
                        rBLL._HOSPEDE = informacoesUsuario.idHospede;
                        rBLL.idFormaPagamento = idPagamento;
                        rBLL._FUNCIONARIO = informacoesUsuario.funcionarioId;
                        rDAO.cadastrarReserva(rBLL);

                    }
                    valortotalCompra = 0;
                    lblTotal.Text = "Total: " + valortotalCompra;
                    dtReserva.Rows.Clear();
                    this.Hide();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }
        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            dtReserva.Rows.Clear();
            this.Hide();
        }

        private void btnLeftCalender_Click(object sender, EventArgs e)
        {
            int i = int.Parse(cbMes.SelectedItem.ToString()) - 1;

            if (i.ToString().Length == 1)
            {
                cbMes.SelectedItem = "0" + i;
            }
            if (i == 12)
            {
                cbMes.SelectedIndex = 11;
            }
            else
            {
                cbMes.SelectedItem = i.ToString();
            }
            if (i == 0)
            {
                cbAno.SelectedIndex = cbAno.SelectedIndex - 1;
                cbMes.SelectedIndex = 11;
            }
            AnoMes();
        } /*VOLTAR O MÊS */
        #endregion
        private void populandoComboBoxQuarto()
        {
            string sql = "SELECT * FROM tbl_Quarto";
            DataTable dtDepartamento = qDAO.BuscandoTudo(sql);
            cbQuarto.DataSource = dtDepartamento;
            cbQuarto.DisplayMember = "nome";
            cbQuarto.ValueMember = "ID";
            txtDiaria.DataBindings.Add("text", dtDepartamento, "preco");
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void gunaGradientButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
