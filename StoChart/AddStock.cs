using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Alpha_Vantage_CS
{
    class AddStock
    {
        private string strContraction;
        private string strJSONStock;
        private string strJSONDiv;


       public void SetContraction(string Contraction)
        {
            this.strContraction = Contraction;
        }
       public void SetJSONString()
        {
            string strConn = ("https://api.iextrading.com/1.0/stock/market/batch?symbols=<0>&types=quote,chart&range=1m&last=1");
            strConn=strConn.Replace("<0>", strContraction);
          
        

            System.Net.WebClient webClient = new WebClient();
            webClient.Proxy = HttpWebRequest.GetSystemWebProxy();
            webClient.Proxy.Credentials = CredentialCache.DefaultCredentials;

            Stream strm = webClient.OpenRead(strConn);
            StreamReader sr = new StreamReader(strm);

            this.strJSONStock = sr.ReadToEnd();
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

  
       public void AddStockToDB()
        {
           // Verbindung mit Datenbank


            CDataStock StockData = JsonConvert.DeserializeObject<CDataStock>(this.strJSONStock);
          //  Console.WriteLine(this.strJSONDiv);
           if(this.strJSONDiv.Length >15)
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

       public string GetStockData() {

           return this.strJSONStock;
       
       }

    }
}
