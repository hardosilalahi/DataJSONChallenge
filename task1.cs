using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.IO;

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
        public string Birthday{get; set;}
        public List<string> Phones{get; set;}
    }
    public class articles{
        public int Id{get; set;}
        public string Title{get; set;}
        public string Published_at{get; set;}
    }
    public class noPhoneNumber{
        static string filePath = @"/Users/user/JsonChallenge/jsonFiles/data1.json";

        public List<string> UserNoPhone(){
            var json = File.ReadAllText(filePath);

            var jObject = JsonConvert.DeserializeObject<List<user>>(json);

            List<string> result = new List<string>();

            foreach(var i in jObject){
                if(i.Profile.Phones.Count == 0){
                    result.Add(i.Username);
                }
            }
            return result;
        }
    }

    public class HaveArticles{
        static string filePath = @"/Users/user/JsonChallenge/jsonFiles/data1.json";

        public List<string> UserArticles(){
            var json = File.ReadAllText(filePath);

            var jObject = JsonConvert.DeserializeObject<List<user>>(json);

            List<string> result = new List<string>();

            foreach(var i in jObject){
                if(i.Articles.Count != 0){
                    result.Add(i.Username);
                }
            }
            return result;
        }
    }

    public class HaveAnnis{
        static string filePath = @"/Users/user/JsonChallenge/jsonFiles/data1.json";

        public List<string> NameAnnis(){
            var json = File.ReadAllText(filePath);

            var jObject = JsonConvert.DeserializeObject<List<user>>(json);

            List<string> result = new List<string>();

            foreach(var i in jObject){
                if(i.Profile.Full_name.Contains("Annis") == true){
                    result.Add(i.Username);
                }
            }
            return result;
        }
    }

    public class Article2020{
        static string filePath = @"/Users/user/JsonChallenge/jsonFiles/data1.json";

        public List<string> Year2020(){
            var json = File.ReadAllText(filePath);

            var jObject = JsonConvert.DeserializeObject<List<user>>(json);

            List<string> result = new List<string>();

            foreach(var i in jObject){
                foreach(var j in i.Articles){
                    if(j.Published_at.Contains("2020") == true){
                        result.Add(i.Username);
                    }
                }
            }
            return result;
        }
    }

    public class UserBoomer{
        static string filePath = @"/Users/user/JsonChallenge/jsonFiles/data1.json";

        public List<string> Born1986(){
            var json = File.ReadAllText(filePath);

            var jObject = JsonConvert.DeserializeObject<List<user>>(json);

            List<string> result = new List<string>();

            foreach(var i in jObject){
                if(i.Profile.Birthday.Contains("1986") == true){
                    result.Add(i.Username);
                }
            }
            return result;
        }
    }

    public class ContainsTips{
        static string filePath = @"/Users/user/JsonChallenge/jsonFiles/data1.json";

        public List<string> LinusTips(){
            var json = File.ReadAllText(filePath);

            var jObject = JsonConvert.DeserializeObject<List<user>>(json);

            List<string> result = new List<string>();

            foreach(var i in jObject){
                foreach(var j in i.Articles){
                    if(j.Title.Contains("Tips") == true){
                        result.Add(i.Username);
                    }
                }
            }
            return result;
        }
    }
}