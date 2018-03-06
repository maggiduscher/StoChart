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
using System.Data.SQLite;

namespace DataLoader {

    static class DL
    {

        static public void f_LoadStock(System.Windows.Forms.DataVisualization.Charting.Chart chart, CDataStock DataStock) {

            chart.Series.Add(DataStock.quote.symbol);
            chart.Series[DataStock.quote.symbol].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart.Series[DataStock.quote.symbol].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            chart.Series[DataStock.quote.symbol].Points.Clear();

            List<DateTime> l_data = new List<DateTime>();
            List<int> l_Y = new List<int>();

            foreach (Chart chart1 in DataStock.chart) {

                l_data.Add(Convert.ToDateTime(chart1.date));
                l_Y.Add(Convert.ToInt32(chart1.close));
                if (Convert.ToInt32(chart1.close) > chart.ChartAreas[0].AxisY.Maximum) chart.ChartAreas[0].AxisY.Maximum = Convert.ToInt32(chart1.close) + 20;
                else if (Convert.ToInt32(chart1.close) < chart.ChartAreas[0].AxisY.Minimum && (chart1.close - 20) > 0) chart.ChartAreas[0].AxisY.Minimum = Convert.ToInt32(chart1.close) - 20;
                else if (Convert.ToInt32(chart1.close) < chart.ChartAreas[0].AxisY.Minimum && (chart1.close - 20) <= 0) chart.ChartAreas[0].AxisY.Minimum = Convert.ToInt32(chart1.close);

            };

            DateTime[] d_data = l_data.ToArray();
            int[] i_Y = l_Y.ToArray();

            chart.Series[DataStock.quote.symbol].Points.DataBindXY(d_data, i_Y);

           
        }

        public static void f_AddStock(string Kuerzel, string WKN, string ISIN, string Menge, string Depot) {

            if (Kuerzel.Trim() != "" && WKN.Trim() != "" && ISIN.Trim() != "" && Menge.Trim() != "" /*&& Depot.Trim() != ""*/)
            {
                AddStock AT = new AddStock();
                AT.SetContraction(Kuerzel);
                if (!AT.SetJSONString()) 
                {
                    MessageBox.Show("Aktie nicht Gefunden");
                }
                else
                {

                    SQLiteConnection connection = new SQLiteConnection("Data Source= StoChart.sqllite");
                    try
                    {
                         connection.Open();
                         SQLiteCommand command = new SQLiteCommand(connection);
                         command.CommandText = "SELECT * FROM Aktien WHERE Kuerzel = Kürzel";
                         SQLiteDataReader reader = command.ExecuteReader();

                         if (reader.HasRows)
                         {
                             command.CommandText = "INSERT INTO Aktien()VALUES()";
                             command.ExecuteNonQuery();
                         }


                         command.CommandText = "INSERT INTO GekaufteAktien()VALUES()";
                         command.ExecuteNonQuery();

                         connection.Close();


                    }
                    catch (InvalidCastException e)
                    {

                    }
                    finally
                    {
                          connection.Close();
                    }

                   
                  
                }

                //get Depot ID
                //get Aktien
                //Aktie nicht vorhanden -> eintragen
                //Aktien erhöhen

            }
            else MessageBox.Show("Bitte überprüfen Sie ihre Angaben!");

        }

        public static void f_changeDepot() { 
        
            //Depot aus der Datenbank laden
            //Eintragen in die entsprechenden Felder
        
        }
    
    }

}