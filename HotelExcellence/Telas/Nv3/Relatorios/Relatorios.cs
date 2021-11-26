using Banco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HotelExcellence.Telas.Nv3.Relatorios
{
    public partial class Relatorios : Form
    {
        FuncionarioDAO fDAO = new FuncionarioDAO();
        public Relatorios()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void getGraficColumnsYear() {
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Legends.Clear();

            Title title = new Title();
            title.Font = new Font("Arial", 14, FontStyle.Bold);
            title.ForeColor = Color.Brown;
            title.Text = "Vendas Mensais";
            chart1.Titles.Add(title);

            // Inserir leganda
            Legend legend = new Legend();
            chart1.Legends.Add(legend);
            chart1.Legends[0].Title = "Legenda";

            //Titulos dos eixtos X e Y
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Comparação entre os anos";
            chart1.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);

            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Faturamento";
            chart1.ChartAreas["ChartArea1"].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);

            //remover grades verticais
            chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;

            //Vendas Reais
            chart1.Series.Add("vendas");
            chart1.Series["vendas"].LegendText = "Vendas Anual";
            chart1.Series["vendas"].ChartType = SeriesChartType.Column;
            chart1.Series["vendas"].BorderWidth = 1;




            string sql = "SELECT  year(R.reserva) AS 'Ano', COUNT(F.ID) AS 'Quantidade de vendas', SUM(F.valor) AS Total FROM tbl_Reserva AS R, tbl_FormaPagamento AS F GROUP BY year(R.reserva) ORDER BY TOTAL DESC";// Program.Global.nPermissao;
            DataTable dt = fDAO.BuscandoTudo(sql);

            try
            {
               for (int i = 0; i <= dt.Rows.Count; i++)
                {
                    int x = int.Parse(dt.Rows[i]["ano"].ToString());
                    double y = double.Parse(dt.Rows[i][2].ToString());
                    chart1.Series["vendas"].Points.AddXY("" + x + "", y);
                }
            }
            catch (Exception)
            {

            }
 

        }

        private void getGraficColumnsMonth( )
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Legends.Clear();

            string sql = " SELECT year(R.reserva) AS 'Ano', COUNT(F.ID) AS 'Quantidade de vendas', SUM(F.valor) AS Total FROM tbl_Reserva AS R, tbl_FormaPagamento AS F GROUP BY year(R.reserva) ORDER BY Ano ASC";
            DataTable dt = fDAO.BuscandoTudo(sql); 
                int[] ano = new int[int.Parse(dt.Rows.Count.ToString())];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
               
                ano[i] = int.Parse(dt.Rows[i]["Ano"].ToString());
            }

            sql = " SELECT  MONTH(R.reserva) AS 'Mes', YEAR(R.reserva) AS 'Ano', COUNT(F.ID) AS 'Quantidade de vendas', SUM(F.valor) AS Total FROM tbl_Reserva AS R, tbl_FormaPagamento AS F  GROUP BY MONTH(R.reserva), YEAR(R.reserva) ORDER BY YEAR(R.reserva) ASC";
            dt = fDAO.BuscandoTudo(sql);
            try
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    if (ano[i] == int.Parse(dt.Rows[i]["Ano"].ToString()))
                    {
                        string table = ano[i].ToString();
                        chart1.Series.Add(ano[i].ToString());
                        chart1.Series[ano[i].ToString()].LegendText = dt.Rows[i]["mes"].ToString();
                        chart1.Series[ano[i].ToString()].ChartType = SeriesChartType.Column;
                        chart1.Series[ano[i].ToString()].BorderWidth = 1;



                        int x = int.Parse(dt.Rows[i]["mes"].ToString());
                        double y = double.Parse(dt.Rows[i]["total"].ToString());
                        chart1.Series[table].Points.Add(x, y);
                    }
                }
            }
            catch (Exception)
            {

               // throw;
            }
            


            //sql = "SELECT   YEAR(R.reserva) AS 'ANO', MONTH(R.reserva) AS 'Mes',COUNT(F.ID) AS 'Quantidade de vendas', SUM(F.valor) AS Total FROM tbl_Reserva AS R, tbl_FormaPagamento AS F GROUP BY MONTH(R.reserva), YEAR(R.reserva) ORDER BY TOTAL DESC";
            //dt = fDAO.BuscandoTudo(sql);

            //try
            //{
                
            //    for (int i = 0; i <= dt.Rows.Count; i++)
            //    {
            //        int anosa;
            //        if (dt.Rows[i]["ano"].ToString() == anos) { 
            //            chart1.Series.Add(dt.Rows[i]["mes"].ToString());
            //            chart1.Series[dt.Rows[i]["mes"].ToString()].LegendText = dt.Rows[i]["mes"].ToString();
            //            chart1.Series[dt.Rows[i]["mes"].ToString()].ChartType = SeriesChartType.Column;
            //            chart1.Series[dt.Rows[i]["mes"].ToString()].BorderWidth = 1;
            //        /*
            //        int x = int.Parse(dt.Rows[i]["mes"].ToString());
            //        double y = double.Parse(dt.Rows[i][2].ToString());*/
            //            chart1.Series[dt.Rows[i]["mes"].ToString()].Points.Add(dt.Rows[i]["mes"].ToString()[i], 100);
            //        }
                   
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            getGraficColumnsMonth();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            getGraficColumnsYear();
        }
    }
}
