using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
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
        List<CDepot> Depots = new List<CDepot>();
        public StoChart()
        {
            InitializeComponent();

            if (File.Exists(@"C:\Users\" + Environment.UserName + @"\StoChart\config.conf")){

                StreamReader sr = new StreamReader(@"C:\Users\"+ Environment.UserName +@"\StoChart\config.conf");
                sr.Close();

            }
            else {

                Directory.CreateDirectory(@"C:\Users\" + Environment.UserName + @"\StoChart");
                SQLiteConnection.CreateFile(@"C:\Users\" + Environment.UserName + @"\StoChart\StoChart.sqlite");
                SQLiteConnection db_Connection = DL.f_connectDatabase();
                db_Connection.Open();
                DL.f_fillDatabase(db_Connection);
                db_Connection.Close();
                StreamWriter sw = new StreamWriter(@"C:\Users\"+ Environment.UserName +@"\StoChart\config.conf");
                sw.Close();
                StreamReader sr = new StreamReader(@"C:\Users\" + Environment.UserName + @"\StoChart\config.conf");
                sr.Close();

            }
            Load_Sparplan();
            CheckSparplan();
            Depots.Add(new CDepot(0));
            
            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisY.Minimum = 999999;
            chart1.ChartAreas[0].AxisY.Maximum = 0;
            ch_stock.Series.Clear();
            radioButton1.Checked = true;
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CheckSparplan()
        {
            DL.f_CheckSparplan();
        }

        private void Load_Sparplan()
        {
            DL.f_LoadSparplan(this.Sparplan_List);
        }

        private void b_aktien_Click(object sender, EventArgs e)
        {



            DL.f_AddStock(tb_Kuerzel.Text, tb_WKN.Text, tb_ISIN.Text, tb_Menge.Text, cb_Depot_Stock.SelectedItem.ToString(), Preis.Text, dateTimePicker1.Text, chart1, clb_stock);
            int dummy;
            dummy = cb_charts.SelectedIndex;
            cb_charts.SelectedIndex = cb_charts.Items.Count - 1;
            cb_charts.SelectedIndex = dummy;


        }

        private void cb_Depot_SelectedIndexChanged(object sender, EventArgs e)
        {

           DL.f_changeDepot(cb_Depot.SelectedItem.ToString(), dataGridView1);

        }

        private void StoChart_Load(object sender, EventArgs e)
        {

            DL.f_loadStocks(chart1);

            DL.f_fillStockList(clb_stock);

            DL.f_loadDepotList(cb_Depot_Stock, cb_Depot, cb_charts);
        
        }

        private void clb_stock_SelectedIndexChanged(object sender, EventArgs e)
        {
            DL.f_loadCheckedStocks(clb_stock, chart1);
        }

        private void b_Depot_Click(object sender, EventArgs e)
        {

           DL.f_AddDepot(tb_Depot.Text, cb_Depot_Stock, cb_Depot, cb_charts);
			
        }

        private void Add_Click(object sender, EventArgs e)
        {
            DL.f_AddSparPlan(this.Depot.Text, this.Summe.Text, this.Ausfuerung.Text, this.Kuerzel.Text, this.StartDate.Text);
            this.Sparplan_List.Items.Clear();
            Load_Sparplan();
        }

        private void Sparplan_List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Sparplan_Click(object sender, EventArgs e)
        {

            string Text;
            int ID = 0;

            foreach (object itemChecked in this.Sparplan_List.CheckedItems)
            {
                Text = itemChecked.ToString();
                ID = Convert.ToInt32(Text.Split('@')[1]);
                DL.f_DeleteSparplan(ID);
            }

            this.Sparplan_List.Items.Clear();
            Load_Sparplan();
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RadioButton[] rb = {radioButton1, radioButton2, radioButton3};
            if (cb_charts.SelectedItem != null)  DL.f_DepotChartChange(cb_charts.SelectedItem.ToString(), ch_stock, rb);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton[] rb = { radioButton1, radioButton2, radioButton3 };
            if(cb_charts.SelectedItem != null) DL.f_ChartTypeChange(cb_charts.SelectedItem.ToString(), ch_stock, rb);
        }
    }
}
