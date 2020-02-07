using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json.Linq;

namespace JsonChallenge
{
    public class inventaris
    {
        public int Inventory_id{get; set;}
        public string Name{get; set;}
        public string Type{get; set;}
        public List<string> Tags{get; set;}
        public int Purchased_at{get; set;}
        public penempatan Placement{get; set;}
    }

    public class penempatan{
        public int Room_id{get; set;}
        public string Name{get; set;}
    }

    public class MeetingRoom{
        static string filePath = @"/Users/user/JsonChallenge/jsonFiles/data3.json";
        static string savePath = @"/Users/user/JsonChallenge/jsonFiles/items.json";

        public static void HasItems(){
            var json = File.ReadAllText(filePath);
            var jObject = JsonConvert.DeserializeObject<List<inventaris>>(json);

            var result = new List<inventaris>();

            foreach(var i in jObject){
                if(i.Placement.Name == "Meeting Room"){
                    result.Add(i);
                }
            }

            var savedFile = JsonConvert.SerializeObject(result);
            File.WriteAllText(savePath, savedFile);

        }

    }

    public class ElectronicDevices{
        static string filePath = @"/Users/user/JsonChallenge/jsonFiles/data3.json";
        static string savePath = @"/Users/user/JsonChallenge/jsonFiles/electronic.json";


        public static void HasElectronic(){
            var json = File.ReadAllText(filePath);
            var jObject = JsonConvert.DeserializeObject<List<inventaris>>(json);

            var result = new List<inventaris>();

            foreach(var i in jObject){
                if(i.Type == "electronic"){
                    result.Add(i);
                }
            }
            
            var savedFile = JsonConvert.SerializeObject(result);
            File.WriteAllText(savePath, savedFile);
        }
    }

    public class Furnitures{
        static string filePath = @"/Users/user/JsonChallenge/jsonFiles/data3.json";
        static string savePath = @"/Users/user/JsonChallenge/jsonFiles/furnitures.json";


        public static void HasFurnitures(){
            var json = File.ReadAllText(filePath);
            var jObject = JsonConvert.DeserializeObject<List<inventaris>>(json);

            var result = new List<inventaris>();

            foreach(var i in jObject){
                if(i.Type == "furniture"){
                    result.Add(i);
                }
            }
            
            var savedFile = JsonConvert.SerializeObject(result);
            File.WriteAllText(savePath, savedFile);
        }
    }

    public class PurchasedAt{
        static string filePath = @"/Users/user/JsonChallenge/jsonFiles/data3.json";
        static string savePath = @"/Users/user/JsonChallenge/jsonFiles/purchased-at-2020-01-16.json";

        public static void HasPurchased(){
            var json = File.ReadAllText(filePath);
            var jObject = JsonConvert.DeserializeObject<List<inventaris>>(json);

            var result = new List<inventaris>();

            foreach(var i in jObject){
                var timestamp = i.Purchased_at;
                var tanggal = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).AddSeconds(timestamp);
                if(tanggal.Year == 2020 && tanggal.Day == 16 && tanggal.Month == 01){
                    result.Add(i);
                }
            }
            
            var savedFile = JsonConvert.SerializeObject(result);
            File.WriteAllText(savePath, savedFile);
        }
    }

    public class ItemBrown{
        static string filePath = @"/Users/user/JsonChallenge/jsonFiles/data3.json";
        static string savePath = @"/Users/user/JsonChallenge/jsonFiles/all-browns.json";

        public static void HasBrown(){
            var json = File.ReadAllText(filePath);
            var jObject = JsonConvert.DeserializeObject<List<inventaris>>(json);

            var result = new List<inventaris>();

            foreach(var i in jObject){
                if(i.Tags.Contains("brown") == true){
                    result.Add(i);
                }
            }
            
            var savedFile = JsonConvert.SerializeObject(result);
            File.WriteAllText(savePath, savedFile);
        }
    }
}