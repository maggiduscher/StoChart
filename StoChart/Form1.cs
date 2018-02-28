using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using System.Net;
using System.IO;
using DataLoader;
using Alpha_Vantage_CS;
using Newtonsoft.Json;

namespace StoChart
{
    public partial class StoChart : Form
    {
        private bool b_StLoaded;
        public StoChart()
        {
            InitializeComponent();
            if (File.Exists(@"C:\Users\" + Environment.UserName + @"\StoChart\config.conf"))
            {

                StreamReader sr = new StreamReader(@"C:\Users\"+ Environment.UserName +@"\StoChart\config.conf");

            }
            else {

                Directory.CreateDirectory(@"C:\Users\" + Environment.UserName + @"\StoChart");
                StreamWriter sw = new StreamWriter(@"C:\Users\"+ Environment.UserName +@"\StoChart\config.conf");
                sw.Close();
                StreamReader sr = new StreamReader(@"C:\Users\" + Environment.UserName + @"\StoChart\config.conf");
                sr.Close();

            }

            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisY.Minimum = 999999;
            chart1.ChartAreas[0].AxisY.Maximum = 0;
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {


            AddStock AdSt = new AddStock();

            AdSt.SetContraction("AAPL");
            AdSt.SetJSONString();

            CDataStock StockData = JsonConvert.DeserializeObject<CDataStock>(AdSt.GetStockData());
            
            DL.f_LoadStock(chart1, StockData);

            AdSt.SetContraction("SAP");
            if (!AdSt.SetJSONString()) MessageBox.Show("Kürzel nicht gefunden?!");
            else
            {
                StockData = JsonConvert.DeserializeObject<CDataStock>(AdSt.GetStockData());

                DL.f_LoadStock(chart1, StockData);

            }




        }

        private void b_aktien_Click(object sender, EventArgs e)
        {

            DL.f_AddStock(tb_Kuerzel.Text, tb_WKN.Text, tb_ISIN.Text, tb_Menge.Text, cb_Depot_Stock.SelectedText);
            
        }

        private void cb_Depot_SelectedIndexChanged(object sender, EventArgs e)
        {

           // DL.f_changeDepot(cb_Depot.SelectedText);

        }
    }
}
