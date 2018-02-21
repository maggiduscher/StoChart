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

namespace StoChart
{
    public partial class Form1 : Form
    {
        private bool b_StLoaded;
        public Form1()
        {
            InitializeComponent();
            if (File.Exists(@"C:\StoChart.conf"))
            {

                StreamReader sr = new StreamReader(@"C:\Users\"+ Environment.UserName +@"\StoChart.conf");
                StreamWriter sw = new StreamWriter(@"C:\Users\" + Environment.UserName + @"\StoChart.conf");

            }
            else { 
            
                StreamWriter sw = new StreamWriter(@"C:\Users\"+ Environment.UserName +@"\StoChart.conf");
            
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

                DL.f_LoadStock(chart1);




        }
    }
}
