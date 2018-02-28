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
            if (File.Exists(@"C:\StoChart\config.conf"))
            {

                StreamReader sr = new StreamReader(@"C:\Users\"+ Environment.UserName +@"\StoChart\config.conf");

            }
            else {

                Directory.CreateDirectory(@"C:\StoChart");
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
            AdSt.SetJSONString();

            StockData = JsonConvert.DeserializeObject<CDataStock>(AdSt.GetStockData());

            DL.f_LoadStock(chart1, StockData);




        }
    }
}
