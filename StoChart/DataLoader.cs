﻿using System;
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

namespace DataLoader {

    class BuyStock
    {
        public BuyStock()
        {
            this.Auftrag_ID = 0;
            this.Date = DateTime.Now;
            this.Depot = 0;
            this.Geld = 0;
            this.Kuerzel = " ";
            this.Zeit = " ";
        }
        public BuyStock(string Kuerzel, DateTime Date, float Geld, int Depot, int Auftrag_ID, string Zeit)
        {
            
            this.Date = Date;
            this.Depot = Depot;
            this.Geld = Geld;
            this.Kuerzel = Kuerzel;
            this.Auftrag_ID = Auftrag_ID;
            this.Zeit = Zeit;
        }
        public string Kuerzel { get; set; }
       public DateTime Date { get; set; }
       public float Geld { get; set; }
       public int Depot { get; set; }
       public int Auftrag_ID { get; set; }
       public string Zeit { get; set; }
    }

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

        public static void f_DeleteSparplan(int ID)
        {
            SQLiteConnection connection = f_connectDatabase();
            try
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "DELETE FROM `Daueraufträge`" +
                    "WHERE `Auftrag-ID` = " + ID+";";

                command.ExecuteNonQuery();

            }
            catch (InvalidCastException ep)
            {
                MessageBox.Show("Fehler :" + ep.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        public static void f_BuyStocks(List<BuyStock> list)
        {
            foreach(var item in list)
            {
                AddStock AT = new AddStock();
                AT.SetContraction(item.Kuerzel);
                if (!AT.SetJSONString()) // Prüfe ob das Kürzel Richtig ist
                {
                    MessageBox.Show("Fehler die Aktie mit dem Kürzel " + item.Kuerzel + " gibt es nicht");
                }
                else
                {
                    AT.SetStockData();
                    float Preis = AT.GetPreis(item.Date);
                    if (Preis == 0)
                    {

                    }
                    else
                    {
                        double Anzahl = Math.Round((item.Geld / Preis), 4);

                        SQLiteConnection connection = f_connectDatabase();
                        try
                        {



                            connection.Open();
                            SQLiteCommand command = new SQLiteCommand(connection);
                            command.CommandText = "INSERT INTO `gekaufteAktien`(`Kürzel`,`Depot-ID`,`Datum`,`Kaufkurs`,`Anzahl`)" +
                                " VALUES('" + item.Kuerzel + "'," + item.Depot + ",'" + item.Date.ToString() + "'," + Preis.ToString().Replace(',', '.') + "," + Anzahl.ToString().Replace(',', '.') + ")";
                            command.ExecuteNonQuery();


                            int Months = 0;
                            switch (item.Zeit.Trim())
                            {
                                case "pro Monat":
                                    Months = 1;
                                    break;
                                case "pro Quartal":
                                    Months = 4;
                                    break;
                                case "pro Halbjahr":
                                    Months = 6;
                                    break;
                            }

                            item.Date = item.Date.AddMonths(Months);

                            command.CommandText = "UPDATE `Daueraufträge`" +
                                " SET `Nächste_Aufführung` = '" + item.Date.ToString() + "' " +
                                "WHERE `Auftrag-ID` = " + item.Auftrag_ID + "";
                            command.ExecuteNonQuery();
                        }
                        catch (InvalidCastException ep)
                        {
                            MessageBox.Show("Fehler :" + ep.Message);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }



                }
            }
           
        }

        public static void f_CheckSparplan()
        {
            SQLiteConnection connection = f_connectDatabase();
            try
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "SELECT * FROM `Daueraufträge`";   
                SQLiteDataReader reader = command.ExecuteReader();
                DateTime NextPurchase;
                DateTime Now = DateTime.Now;
                List<BuyStock> list = new List<BuyStock>();

                while (reader.Read())
                {
                    NextPurchase = Convert.ToDateTime(reader["Nächste_Aufführung"].ToString());
                    if(Now > NextPurchase)
                    {
                        list.Add(new BuyStock(reader["Kürzel"].ToString(), NextPurchase, float.Parse(reader["Kosten"].ToString()), Convert.ToInt32(reader["Kosten"].ToString()), Convert.ToInt32(reader["Auftrag-ID"]), reader["Zeit"].ToString()));
                        
                        
                    }
                    
                }
                if(list != null)
                {
                    f_BuyStocks(list);
                }

                reader.Close();

            }
            catch (InvalidCastException ep)
            {
                MessageBox.Show("Fehler :" + ep.Message);
            }
            finally
            {
                connection.Close();
               
            }
        }

        public static void f_LoadSparplan(System.Windows.Forms.CheckedListBox Sparplan)
        {

            SQLiteConnection connection = f_connectDatabase();
            try
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "Select `Daueraufträge`.*,`Aktien`.`Name` FROM `Daueraufträge` " +
               //     "INNER JOIN `Depot` ON(`Daueraufträge`.`Depot-ID` LIKE `Depot`.`Depot-ID`) "
               "INNER JOIN `Aktien` ON(`Daueraufträge`.`Kürzel` LIKE `Aktien`.`Kürzel`)";
                SQLiteDataReader reader = command.ExecuteReader();
                string Text = "";
                while(reader.Read())
                {
                    Text = reader["Name"] + " " + reader["Kosten"] + "€ "+ reader["Zeit"] + "\t\t\t\t\t\t\t\t@" + reader["Auftrag-ID"];
                    Sparplan.Items.Add(Text, false);
                }

                reader.Close();
            }
            catch (InvalidCastException ep)
            {
                MessageBox.Show("Fehler :" + ep.Message);
            }
            finally
            {
                connection.Close();
              
            }

        }

        public static void f_AddDepot(string Name)
        {
            SQLiteConnection connection = f_connectDatabase();
            try
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "INSERT INTO `Depot`(Name)" +
                                       "VALUES('" + Name + "')";
                command.ExecuteNonQuery();

            }
            catch (InvalidCastException ep)
            {
                MessageBox.Show("Fehler :" + ep.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private static bool CheckAktieinDB(string Kuerzel)
        {
            SQLiteConnection connection = f_connectDatabase();
            
            try
            {
                connection.Open();
                SQLiteCommand com = new SQLiteCommand(connection);
               
                com.CommandText = "SELECT * FROM `Aktien` WHERE `Kürzel` = '" + Kuerzel + "';";
                SQLiteDataReader reader = com.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    connection.Close();
                    return true;
                }

            }
            catch (InvalidCastException e)
            {
                MessageBox.Show("Fehler :" + e.Message);
            }
            finally
            {

                connection.Close();
            }

            return false;
        }
        public static void f_AddSparPlan(string Depot, string Summe, string Ausfuerung, string Kürzel, string Date)
        {
            if(/*Depot.Trim() != "" &&*/ Ausfuerung.Trim() != "" && Kürzel.Trim() != "" )
            {
              

                float i = 0;
                if (!(float.TryParse(Summe, out i)))
                {
                    MessageBox.Show("Ungültige Zahlenangabe");
                }
                else if(!CheckAktieinDB(Kürzel))
                {
                    MessageBox.Show("Aktie steht nich in der Dantenbank");
                }
                else
                {
                    float summe = float.Parse(Summe);
                    float depot_id = 0;
                    SQLiteConnection connection = f_connectDatabase();
                    try
                    {

                        connection.Open();
                        SQLiteCommand command = new SQLiteCommand(connection);
                        command.CommandText = "INSERT INTO `Daueraufträge`(`Depot-ID`,`Kürzel`,`Kosten`,`Zeit`,`Nächste_Aufführung`)VALUES(" + depot_id +",'"+ Kürzel + "',"+ summe +",' "+ Ausfuerung +"','"+ Date+"');";
                        command.ExecuteNonQuery();

                    }
                    catch (InvalidCastException e)
                    {
                        MessageBox.Show("Fehler :" + e.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }
            else
            {
                MessageBox.Show("Ungültige Eingabe");
            }
        }
        public static void f_AddStock(string Kuerzel, string WKN, string ISIN, string Menge, string Depot, string Preis, string Date, System.Windows.Forms.DataVisualization.Charting.Chart chart1, System.Windows.Forms.CheckedListBox clb)
        {

            if (Kuerzel.Trim() != "" && WKN.Trim() != "" && ISIN.Trim() != "" && Menge.Trim() != "" && Preis.Trim() != "" && Date.Trim() != ""/*&& Depot.Trim() != ""*/)
            {

                // Prüfe nach gültigen Zahlenwerten
                float i = 0;
                if (!(float.TryParse(Menge, out i) && float.TryParse(Preis, out i)))
                {
                    MessageBox.Show("Ungültige Zahlenangabe");
                }
                else
                {
                    Depot = "0";
                    float menge = float.Parse(Menge);
                    float preis = float.Parse(Preis);
                    int depot = Convert.ToInt32(Depot);

                    AddStock AT = new AddStock();
                    AT.SetContraction(Kuerzel);
                    if (!AT.SetJSONString()) // Prüfe ob das Kürzel Richtig ist
                    {
                        MessageBox.Show("Aktie nicht Gefunden");
                    }
                    else
                    {
                        AT.SetStockData();
                        string Name = AT.GetStockName();

                        SQLiteConnection connection = f_connectDatabase();
                        try
                        {

                            connection.Open();
                            SQLiteCommand command = new SQLiteCommand(connection);
                            command.CommandText = "SELECT * FROM `Aktien` WHERE Kürzel LIKE '" + Kuerzel + "';";
                            SQLiteDataReader reader = command.ExecuteReader();
                            if (!reader.HasRows)
                            {

                                reader.Close();
                                //command = new SQLiteCommand(connection);
                                command.CommandText = "INSERT INTO Aktien(Kürzel,WKN,ISIN,Name)" +
                                    "VALUES('" + Kuerzel + "','" + WKN + "','" + ISIN + "','" + Name + "')";
                                command.ExecuteNonQuery();

                                List<CDividende> listDivi = AT.GetDividende();
                                foreach (var dummy in listDivi)
                                {
                                    command.CommandText = "INSERT INTO Dividende(`Kürzel`,`Datum`,`Ausschüttung`)" +
                                        "VALUES('" + Kuerzel + "','" + dummy.Date + "'," + dummy.Dividende.ToString().Replace(',', '.') + ")";
                                    command.ExecuteNonQuery();
                                }
                            }
                            else { reader.Close(); }



                            //command = new SQLiteCommand(connection);
                            //command.CommandText = "INSERT INTO `Depot`(Name) VALUES('Dummy');";
                            //command.ExecuteNonQuery();


                            command.CommandText = "INSERT INTO `gekaufteAktien`(`Kürzel`,`Depot-ID`,`Datum`,`Kaufkurs`,`Anzahl`)" +
                                " VALUES('" + Kuerzel + "'," + depot + ",'" + Date + "'," + preis + "," + menge + ")";
                            command.ExecuteNonQuery();



                            


                        }
                        catch (InvalidCastException e)
                        {
                            MessageBox.Show("Fehler :" + e.Message);
                        }
                        finally
                        {
                            f_loadStocks(chart1);
                            f_fillStockList(clb);
                            connection.Close();
                        }


                        MessageBox.Show("Nice");
                    }

                    //get Depot ID
                    //get Aktien
                    //Aktie nicht vorhanden -> eintragen
                    //Aktien erhöhen
                }
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

            string sql = @"BEGIN TRANSACTION;
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
	                        `Zeit`	    TEXT NOT NULL,
                            `Nächste_Aufführung`	TEXT NOT NULL,
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

            db_reader.Read();

            int anz = Convert.ToInt32(db_reader["Anzahl"]);
            db_reader.Close();

            sql = "SELECT `Kürzel` FROM `Aktien`;";
            db_command = new SQLiteCommand(sql, db_connection);
            db_reader = db_command.ExecuteReader();

            List<AddStock> AdSt = new List<AddStock>(anz);
            StDa = new List<CDataStock>(anz);

            chart1.Series.Clear();

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

            db_reader.Close();
            db_connection.Close();

        }

        public static void f_fillStockList(System.Windows.Forms.CheckedListBox clb) {

            SQLiteConnection db_connection = DL.f_connectDatabase();
            db_connection.Open();

            string sql = "SELECT `Kürzel` FROM `Aktien`;";
            SQLiteCommand db_command = new SQLiteCommand(sql, db_connection);
            SQLiteDataReader db_reader = db_command.ExecuteReader();

            if (!db_reader.HasRows) {

                db_reader.Close();
                db_connection.Close();
                return;
            
            } 

            clb.Items.Clear();
            while (db_reader.Read()) {

                clb.Items.Add(db_reader["Kürzel"].ToString());

            }

            db_reader.Close();
            db_connection.Close();

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