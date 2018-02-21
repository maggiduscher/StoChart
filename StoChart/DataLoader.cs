using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alpha_Vantage_CS;

namespace DataLoader {

    static class DL
    {

        static public void f_LoadStock(System.Windows.Forms.DataVisualization.Charting.Chart chart, CDataStock DataStock) {

            chart.Series.Add(DataStock.quote.symbol);
            chart.Series[DataStock.quote.symbol].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            chart.Series[DataStock.quote.symbol].Points.Clear();

            List<DateTime> l_data = new List<DateTime>();
            List<int> l_Y = new List<int>();

            foreach (Chart chart1 in DataStock.chart) {

                l_data.Add(Convert.ToDateTime(chart1.date));
                l_Y.Add(Convert.ToInt32(chart1.close));

            };

            DateTime[] d_data = l_data.ToArray();
            int[] i_Y = l_Y.ToArray();

            chart.Series[DataStock.quote.symbol].Points.DataBindXY(d_data, i_Y);

         

           
        }
    
    }

}