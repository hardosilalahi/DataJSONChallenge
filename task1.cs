using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json.Linq;

namespace JsonChallenge
{
    public class user{
        public string Id{get; set;}
        public string Username{get; set;}
        public profile Profile{get; set;}
        public List<articles> Articles{get; set;}
    }
    public class profile{
        public string Full_name{get; set;}
        public DateTime Birthday{get; set;}
        public List<string> Phones{get; set;}
    }
    public class articles{
        public int Id{get; set;}
        public string Title{get; set;}
        public DateTime Published_at{get; set;}
    }
    public class noPhoneNumber{
        static string filePath = @"/Users/user/JsonChallenge/jsonFiles/data1.json";

        public string UserNoPhone(){
            var json = File.ReadAllText(filePath);

            var jObject = JsonConvert.DeserializeObject<List<user>>(json);

            List<string> result = new List<string>();

            foreach(var i in jObject){
                if(i.Profile.Phones.Count == 0){
                    result.Add(i.Username);
                }
            }
            return String.Join(',', result);;
        }
    }

    public class HaveArticles{
        static string filePath = @"/Users/user/JsonChallenge/jsonFiles/data1.json";

        public string UserArticles(){
            var json = File.ReadAllText(filePath);

            var jObject = JsonConvert.DeserializeObject<List<user>>(json);

            List<string> result = new List<string>();

            foreach(var i in jObject){
                if(i.Articles.Count != 0){
                    result.Add(i.Username);
                }
            }
            return String.Join(',', result);
        }
    }

    public class HaveAnnis{
        static string filePath = @"/Users/user/JsonChallenge/jsonFiles/data1.json";

        public string NameAnnis(){
            var json = File.ReadAllText(filePath);

            var jObject = JsonConvert.DeserializeObject<List<user>>(json);

            List<string> result = new List<string>();

            foreach(var i in jObject){
                var x = i.Profile.Full_name.ToLower();
                if(x.Contains("annis") == true){
                    result.Add(i.Username);
                }
            }
            return String.Join(',', result);
        }
    }

    public class Article2020{
        static string filePath = @"/Users/user/JsonChallenge/jsonFiles/data1.json";

        public string Year2020(){
            var json = File.ReadAllText(filePath);

            var jObject = JsonConvert.DeserializeObject<List<user>>(json);

            List<string> result = new List<string>();

            foreach(var i in jObject){
                foreach(var j in i.Articles){
                    var x = j.Published_at.ToLocalTime();
                    if(x.Year == 2020){
                        result.Add(i.Username);
                    }
                }
            }
            var realResult = result.Distinct();
            return String.Join(',', realResult);
        }
    }

    public class UserBoomer{
        static string filePath = @"/Users/user/JsonChallenge/jsonFiles/data1.json";

        public string Born1986(){
            var json = File.ReadAllText(filePath);

            var jObject = JsonConvert.DeserializeObject<List<user>>(json);

            List<string> result = new List<string>();

            foreach(var i in jObject){
                var x = i.Profile.Birthday.ToLocalTime();
                if(x.Year == 1986){
                result.Add(i.Username);
                }
            }
            return String.Join(',', result);
        }
    }

    public class ContainsTips{
        static string filePath = @"/Users/user/JsonChallenge/jsonFiles/data1.json";

        public string LinusTips(){
            var json = File.ReadAllText(filePath);

            var jObject = JsonConvert.DeserializeObject<List<user>>(json);

            List<string> result = new List<string>();

            foreach(var i in jObject){
                foreach(var j in i.Articles){
                    var x = j.Title.ToLower();
                    if(x.Contains("tips") == true){
                        result.Add(j.Title);
                    }
                }
            }
            return String.Join(',', result);
        }
    }

    public class AugustArticle{
        static string filePath = @"/Users/user/JsonChallenge/jsonFiles/data1.json";

        public string BeforeAugust(){
            var json = File.ReadAllText(filePath);

            var jObject = JsonConvert.DeserializeObject<List<user>>(json);

            List<string> result = new List<string>();

            foreach(var i in jObject){
                foreach(var j in i.Articles){
                    var x = j.Published_at.ToLocalTime();
                    if(x.Year <= 2019 && x.Month < 08){
                        result.Add(j.Title);
                    }
                }
            }
            return String.Join(',', result);
        }
    }
}