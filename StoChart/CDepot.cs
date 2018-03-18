using Alpha_Vantage_CS;
using DataLoader;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoChart
{
    class GekaufteAktien
    {
       public string Kuerzel { get; set; }
       public float Anzahl { get; set; }
       public float Kaufkurs { get; set; }
       public float Kurs { get; set; }
       public string Kaufdatum { get; set; }
       public List<CDividende> Dividende = new List<CDividende>();

       public GekaufteAktien(string Kuerzel, float Anzahl, float Kaufkurs, string Kaufdatum)
       {
            this.Kuerzel = Kuerzel;
            this.Anzahl = Anzahl;
            this.Kaufdatum = Kaufdatum;
            this.Kaufkurs = Kaufkurs;

            AddStock Stock = new AddStock();
            Stock.SetContraction(Kuerzel);
            Stock.SetJSONString();
            Stock.SetStockData();
            this.Kurs = Stock.GetlatestPrice();
            this.Dividende = Stock.GetDividende(Kaufdatum);
           
       }
    }
    class Aktien
    {
        public string Kuerzel { get; set; }
        public float Anzahl { get; set; }
        public float Wert { get; set; }

        public Aktien()
        {
            this.Kuerzel = "";
            this.Anzahl = 0;
            this.Wert = 0;
        }

        public Aktien(string Kuerzel, float Anzahl)
        {
            this.Kuerzel = Kuerzel;
            this.Anzahl = Anzahl;
            AddStock Stock = new AddStock();
            Stock.SetContraction(Kuerzel);
            Stock.SetJSONString();
            Stock.SetStockData();
            this.Wert = Anzahl * Stock.GetlatestPrice();

        }

    }
    class CDepot
    {
        public string Name;
        public int ID;
        public List<GekaufteAktien> gekaufeaktien = new List<GekaufteAktien>();
        public List<Aktien> lAktien = new List<Aktien>();

        public CDepot(string Name)
        {
            SQLiteConnection connection = DL.f_connectDatabase();
            try
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "SELECT * FROM `Depot`" +
                    "WHERE `Name` = " + Name + ";";
                SQLiteDataReader reader = command.ExecuteReader();
                reader.Read();
                this.Name = reader["Depot-ID"].ToString();
                reader.Close();

                command.CommandText = "SELECT * FROM `gekaufteAktien`" +
                  "WHERE `Depot-ID` = " + ID + ";";
                reader = command.ExecuteReader();


                while (reader.Read())
                {
                    this.gekaufeaktien.Add(new GekaufteAktien(reader["Kürzel"].ToString(), float.Parse(reader["Anzahl"].ToString()), float.Parse(reader["Kaufkurs"].ToString()), reader["Datum"].ToString()));
                }



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

        public CDepot(int ID)
        {
            SQLiteConnection connection = DL.f_connectDatabase();
            try
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "SELECT * FROM `Depot`" +
                    "WHERE `Depot-ID` = " + ID + ";";
                SQLiteDataReader reader = command.ExecuteReader();
                reader.Read();
                // this.Name = reader["Name"].ToString();
                reader.Close();

                command.CommandText = "SELECT * FROM `gekaufteAktien`" +
                  "WHERE `Depot-ID` = " + ID + ";";
                reader = command.ExecuteReader();


                while(reader.Read())
                {
                    this.gekaufeaktien.Add(new GekaufteAktien(reader["Kürzel"].ToString(), float.Parse( reader["Anzahl"].ToString()), float.Parse(reader["Kaufkurs"].ToString()) , reader["Datum"].ToString()));
                }



            }
            catch (InvalidCastException ep)
            {
                MessageBox.Show("Fehler :" + ep.Message);
            }
            finally
            {
                connection.Close();
            }
            GetAktien();
        }

        private void GetAktien()
        {
           
            SQLiteConnection connection = DL.f_connectDatabase();
            try
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(connection);
                               
                command.CommandText = "SELECT `Kürzel`,SUM(`Anzahl`) AS SUM FROM `gekaufteAktien`" +
                  "WHERE `Depot-ID` = " + ID + " " +
                  "GROUP BY `Kürzel`;";
                SQLiteDataReader reader = command.ExecuteReader();

                string Name = "";
                float Anzahl = 0;

                while (reader.Read())
                {
                    Name = reader["Kürzel"].ToString();
                    Anzahl = float.Parse(reader["SUM"].ToString());
                    this.lAktien.Add(new Aktien(Name,Anzahl));
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

    }
}
