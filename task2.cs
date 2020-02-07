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
            var sum = 0;
            foreach(var i in jObject){
                if(i.Customer.Name == "Ari"){
                    foreach(var j in i.Items){
                        sum += (j.Price * j.Qty);
                    }
                }
            }
            return $"Total Ari's buy: {sum}";
        }
    }
    
    public class GrandPrice{
        static string filePath = @"/Users/user/JsonChallenge/jsonFiles/data2.json";
        
        public string GrandLow(){
            var json = File.ReadAllText(filePath);
            var jObject = JsonConvert.DeserializeObject<List<order>>(json);

            List<string> iritPeople = new List<string>();
            List<string> nameList = new List<string>();

            foreach (var i in jObject){nameList.Add(i.Customer.Name);}

            var buyerList = nameList.Distinct();

            string[] Buyer = buyerList.ToArray();

            int buyerCount = buyerList.Count();
            int jumlah = 0;

            for (int i = 0; i < buyerCount; i++){
                foreach (var j in jObject){
                    if (j.Customer.Name == Buyer[i]){
                        foreach (var k in j.Items){
                            jumlah += ((k.Price) * (k.Qty));
                        }
                    }
                }

                if (jumlah < 300000){
                    iritPeople.Add(Buyer[i]);
                    jumlah = 0;
                }
                else{
                    jumlah = 0;
                }
            }

            return String.Join(',', iritPeople);
        }
    }
}
