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
using Alpha_Vantage_CS;
using Newtonsoft.Json;
using System.Data.SQLite;

namespace DataLoader {

    static class DL
    {

        private static List<CDataStock> StDa;

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

        public static SQLiteConnection f_connectDatabase() {

            SQLiteConnection db_Connection = new SQLiteConnection(@"Data Source=C:\Users\" + Environment.UserName + @"\StoChart\StoChart.sqlite;Version=3;");
            return db_Connection;
        }

        public static void f_fillDatabase(SQLiteConnection db_Connection)
        {

            string sql =@"BEGIN TRANSACTION;
                       CREATE TABLE IF NOT EXISTS `gekaufteAktien` (
	                        `Kürzel`	TEXT NOT NULL,
	                        `Depot-ID`	INTEGER NOT NULL,
	                        `Datum`	TEXT NOT NULL,
	                        `Kaufkurs`	REAL NOT NULL,
	                        `Anzahl`	REAL NOT NULL,
	                        FOREIGN KEY(`Depot-ID`) REFERENCES `Depot`(`Depot-ID`),
	                        FOREIGN KEY(`Kürzel`) REFERENCES `Aktien`(`Kürzel`),
	                        PRIMARY KEY(`Kürzel`,`Depot-ID`,`Datum`)
                        );
                        CREATE TABLE IF NOT EXISTS `Dividende` (
	                        `Kürzel`	TEXT NOT NULL,
	                        `Datum`	TEXT NOT NULL,
	                        `Ausschüttung`	REAL NOT NULL,
	                        PRIMARY KEY(`Kürzel`,`Datum`),
	                        FOREIGN KEY(`Kürzel`) REFERENCES `Aktien`(`Kürzel`)
                        );
                        CREATE TABLE IF NOT EXISTS `Depot` (
	                        `Depot-ID`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	                        `Name`	TEXT NOT NULL
                        );
                        CREATE TABLE IF NOT EXISTS `Daueraufträge` (
	                        `Auftrag-ID`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	                        `Depot-ID`	INTEGER NOT NULL,
	                        `Kürzel`	TEXT,
	                        `Kosten`	REAL NOT NULL,
	                        `Zeit`	TEXT NOT NULL,
	                        FOREIGN KEY(`Kürzel`) REFERENCES `Aktien`(`Kürzel`),
	                        FOREIGN KEY(`Depot-ID`) REFERENCES `Depot`(`Depot-ID`)
                        );
                        CREATE TABLE IF NOT EXISTS `Aktien` (
	                        `Kürzel`	TEXT NOT NULL,
	                        `WKN`	TEXT NOT NULL,
	                        `ISIN`	TEXT NOT NULL,
	                        `Name`	TEXT NOT NULL,
	                        PRIMARY KEY(`Kürzel`)
                        );
                        COMMIT;";

            SQLiteCommand db_Command = new SQLiteCommand(sql, db_Connection);
            db_Command.ExecuteNonQuery();

        }

        public static void f_loadStocks(System.Windows.Forms.DataVisualization.Charting.Chart chart1) {

            SQLiteConnection db_connection = DL.f_connectDatabase();
            db_connection.Open();

            string sql = "SELECT COUNT(`Kürzel`) as \"Anzahl\" FROM `Aktien`;";
            SQLiteCommand db_command = new SQLiteCommand(sql, db_connection);
            SQLiteDataReader db_reader = db_command.ExecuteReader();

            if (!db_reader.HasRows) return;
            db_reader.Read();

            int anz = Convert.ToInt32(db_reader["Anzahl"]);

            sql = "SELECT `Kürzel` FROM `Aktien`;";
            db_command = new SQLiteCommand(sql, db_connection);
            db_reader = db_command.ExecuteReader();

            List<AddStock> AdSt = new List<AddStock>(anz);
            StDa = new List<CDataStock>(anz);

            for (int i = 1; i <= anz; i++)
            {

                AdSt.Add(new AddStock() { });

            }

            foreach (AddStock St in AdSt)
            {

                db_reader.Read();
                St.SetContraction(db_reader["Kürzel"].ToString());
                St.SetJSONString();
                if(St.GetStockData() != null) StDa.Add(JsonConvert.DeserializeObject<CDataStock>(St.GetStockData()));


            }


            foreach (CDataStock SingleStock in StDa)
            {

               f_LoadStock(chart1, SingleStock);

            }
        
        }

        public static void f_fillStockList(System.Windows.Forms.CheckedListBox clb) {

            SQLiteConnection db_connection = DL.f_connectDatabase();
            db_connection.Open();

            string sql = "SELECT `Kürzel` FROM `Aktien`;";
            SQLiteCommand db_command = new SQLiteCommand(sql, db_connection);
            SQLiteDataReader db_reader = db_command.ExecuteReader();

            if (!db_reader.HasRows) return;

            clb.Items.Clear();
            while (db_reader.Read()) {

                clb.Items.Add(db_reader["Kürzel"].ToString());

            }


        }

        public static void f_loadCheckedStocks(System.Windows.Forms.CheckedListBox clb, System.Windows.Forms.DataVisualization.Charting.Chart chart) {

            chart.Series.Clear();
            
            foreach(object itemChecked in clb.CheckedItems){

                foreach(CDataStock C in StDa){

                    if (C.quote.symbol == itemChecked.ToString()) {

                        f_LoadStock(chart, C);
                    
                    }

                }
            
            }
        
        } 
    
    }

}