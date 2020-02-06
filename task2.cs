using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace JsonChallenge
{
    public class order{
        public string Order_id{get; set;}
        public string Created_at{get; set;}
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
                if(i.Created_at.Contains("-02-") == true){
                    result.Add(i.Order_id);
                }
            }
            return String.Join(',', result);
        }
    }

    public class PurchaseAri{
        static string filePath = @"/Users/user/JsonChallenge/jsonFiles/data2.json";

        public List<int> BuyAri(){
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
            return result;
        }
    }
    public class GrandPrice{
        static string filePath = @"/Users/user/JsonChallenge/jsonFiles/data2.json";
        public List<string> GrandLow(){
            var json = File.ReadAllText(filePath);

            var jObject = JsonConvert.DeserializeObject<List<order>>(json);

            List<string> result = new List<string>();
            foreach(var i in jObject){
                foreach(var j in i.Items){
                    var sum = (j.Price * j.Qty);
                    if(sum < 300000){
                        result.Add(i.Customer.Name);
                    }
                }
            }
            return result;
        }
    }

}