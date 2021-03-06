﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace Alpha_Vantage_CS
{
    class CDividende
    {
        public CDividende()
        {
            this.Dividende = 0;
            this.Date = " ";
        }
        public CDividende(float Div, string date)
        {
            this.Dividende = Div;
            this.Date = date;
        }
        public float Dividende { get; set; }
        public string Date { get; set; }
    }
    class AddStock
    {
        private string strContraction;
        private string strJSONStock;
        private string strJSONDiv;
        private CDataStock StockData = new CDataStock();
        private CDividende5Y Dividende = null;


        public void SetContraction(string Contraction)
        {
            this.strContraction = Contraction;
        }
        public bool SetJSONString()
        {
            string strConn = ("https://api.iextrading.com/1.0/stock/market/batch?symbols=<0>&types=quote,chart&range=1m&last=1");
            strConn = strConn.Replace("<0>", strContraction);



            System.Net.WebClient webClient = new WebClient();
            webClient.Proxy = HttpWebRequest.GetSystemWebProxy();
            webClient.Proxy.Credentials = CredentialCache.DefaultCredentials;

            try {

                Stream strm = webClient.OpenRead(strConn);
                StreamReader sr = new StreamReader(strm);

                this.strJSONStock = sr.ReadToEnd();
                if (this.strJSONStock.Length < 3) return false;
                this.strJSONStock = strJSONStock.Substring(strJSONStock.IndexOf(':') + 1, strJSONStock.Length - (strJSONStock.IndexOf(':') + 2));
                this.strJSONStock = strJSONStock.Replace("null", "0");
                strm.Close();


                // Dividende
                strConn = ("https://api.iextrading.com/1.0/stock/<0>/dividends/5y");
                strConn = strConn.Replace("<0>", strContraction);


                strm = webClient.OpenRead(strConn);
                sr = new StreamReader(strm);
                this.strJSONDiv = "{data:";
                this.strJSONDiv += sr.ReadToEnd();
                this.strJSONDiv += "}";
                strm.Close();
            }
            catch {

                return false;
            };


            return true;
        }


        public void AddStockToDB()
        {
            // Verbindung mit Datenbank

            if (this.strJSONStock == null)
            {

            }

            CDataStock StockData = JsonConvert.DeserializeObject<CDataStock>(this.strJSONStock);
            //  Console.WriteLine(this.strJSONDiv);
            if (this.strJSONDiv.Length > 15)
            {
                CDividende5Y Dividende = JsonConvert.DeserializeObject<CDividende5Y>(this.strJSONDiv);
                Console.WriteLine(Dividende.data[0].amount);
            }

            //Console.WriteLine(Dividende.Property1[0].amount);
            //Console.WriteLine(StockData.quote.companyName);
            //Console.WriteLine(StockData.chart[20].close);
            //Console.WriteLine(StockData.chart[20].date);



            string INSERT = "INSERT INTO TABLE()VALUES(<0>)";




        }

        public void SetStockData()
        {

            StockData = JsonConvert.DeserializeObject<CDataStock>(this.strJSONStock);

            if (this.strJSONDiv.Length > 15) Dividende = JsonConvert.DeserializeObject<CDividende5Y>(this.strJSONDiv);
        }

        public string GetStockData()
        {

            return this.strJSONStock;

        }
        public string GetStockName() { return this.StockData.quote.companyName; }


        public List<CDividende> GetDividende()
        {
            List<CDividende> Dummy = new List<CDividende>();
            if (Dividende != null)
            {
                foreach (var data in Dividende.data)
                {
                    Dummy.Add(new CDividende(data.amount, data.exDate));
                }
                return Dummy;
            } return null;
        }

        public List<CDividende> GetDividende(string Date)
        {
            if (this.Dividende != null)
            {
                List<CDividende> Dummy = new List<CDividende>();
                foreach (Datum data in Dividende.data)
                {
                    DateTime StockDate = Convert.ToDateTime(data.exDate);
                    DateTime UserDate = Convert.ToDateTime(Date);
                    if (StockDate > UserDate)
                    {
                        Dummy.Add(new CDividende(data.amount, data.exDate));
                    }


                }
                return Dummy;
            }
            else return null;
        }



        public float GetLatestPrice()
        {
            return StockData.quote.latestPrice;
        }


        public float GetPreis(DateTime Date)
        {
            
            foreach (var data in StockData.chart)
            {
                DateTime StockDate = Convert.ToDateTime(data.date);

                if(StockDate == Date)
                {
                    return data.high;
                }
                else if (StockDate > Date)
                {

                    return data.high;
                }
               
            }

            return 0;
        }



    }
}