using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace JsonChallenge
{
    public class order{
        public string Order_id{get; set;}
        public DateTime Created_at{get; set;}
        public customer Customer{get; set;}
        public List<items> Items{get; set;}
    }
    public class customer{
        public int Id{get; set;}
        public string Name{get; set;}

    }
    public class items{
        public int Id{get; set;}
        public string Name{get; set;}
        public int Qty{get; set;}
        public int Price{get; set;}
    }

    public class purchaseFebruary{
        static string filePath = @"/Users/user/JsonChallenge/jsonFiles/data2.json";

        public string BuyFebruary(){
            var json = File.ReadAllText(filePath);

            var jObject = JsonConvert.DeserializeObject<List<order>>(json);

            List<string> result = new List<string>();

            foreach(var i in jObject){
                var x = i.Created_at.ToLocalTime();
                if(x.Month == 02){
                    result.Add(i.Order_id);
                }
            }
            return String.Join(',', result);
        }
    }

    public class PurchaseAri{
        static string filePath = @"/Users/user/JsonChallenge/jsonFiles/data2.json";

        public string BuyAri(){
            var json = File.ReadAllText(filePath);

            var jObject = JsonConvert.DeserializeObject<List<order>>(json);

            List<int> result = new List<int>();

            foreach(var i in jObject){
                if(i.Customer.Name == "Ari"){
                    foreach(var j in i.Items){
                        result.Add(j.Price * j.Qty);
                    }
                }
            }
            var sum = 0;
            foreach(var jumlah in result){
                sum += jumlah;
            }
            return $"Total Ari's buy: {sum}";
        }
    }
    public class GrandPrice{
        static string filePath = @"/Users/user/JsonChallenge/jsonFiles/data2.json";
        public string GrandLow(){
            var json = File.ReadAllText(filePath);

            var jObject = JsonConvert.DeserializeObject<List<order>>(json);
            var palingIrit = new List<string>();
            List<string> result = new List<string>();
            var ari = new List<int>();
            var ririn = new List<int>();
            var annis = new List<int>();

            foreach(var i in jObject){
                if(i.Customer.Name == "Ari"){
                    foreach(var j in i.Items){
                        ari.Add(j.Price * j.Qty);
                    }
                }
            }

            foreach(var i in jObject){
                if(i.Customer.Name == "Ririn"){
                    foreach(var j in i.Items){
                        ririn.Add(j.Price * j.Qty);
                    }
                }
            }

            foreach(var i in jObject){
                if(i.Customer.Name == "Annis"){
                    foreach(var j in i.Items){
                        annis.Add(j.Price * j.Qty);
                    }
                }
            }
            
            var grandAri = ari.Sum();
            var grandRirin = ririn.Sum();
            var grandAnnis = annis.Sum();

            if(grandAri < 300000){
                palingIrit.Add("Ari");
            }
            if(grandRirin < 300000){
                palingIrit.Add("Ririn");
            }
            if(grandAnnis < 300000){
                palingIrit.Add("Annis");
            }


            return String.Join(',', palingIrit);
        }
    }

}