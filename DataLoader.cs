using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataLoader {

    static class DL
    {

        static public void f_LoadStock(System.Windows.Forms.DataVisualization.Charting.Chart chart) {

            chart.Series["Series1"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            chart.Series["Series1"].Points.Clear();

            DateTime[] data = { Convert.ToDateTime("04-04-2018"), Convert.ToDateTime("01-01-2018") };
            int[] Y = { 2, 1 };

            chart.Series["Series1"].Points.DataBindXY(data, Y);

         

           
        }
    
    }

}