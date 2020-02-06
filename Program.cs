using System.IO;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace JsonChallenge
{

    class Program
    {
        static void Main(string[] args)
        {
            var task1i = new noPhoneNumber();
            var task1ii = new HaveArticles();
            var task1iii = new HaveAnnis();
            var task1iv = new Article2020();
            var task1v = new UserBoomer();
            var task1vi = new ContainsTips();

            var task2i = new purchaseFebruary();
            var task2ii = new PurchaseAri();
            var task2iii = new GrandPrice();
            

            // foreach(var abc in task1i.UserNoPhone()){
            //     Console.WriteLine(abc);
            // }

            // foreach(var abc in task1ii.UserArticles()){
            //     Console.WriteLine(abc);
            // }

            // foreach(var abc in task1iii.NameAnnis()){
            //     Console.WriteLine(abc);
            // }

            // foreach(var abc in task1iv.Year2020()){
            //     Console.WriteLine(abc);
            // }

            // foreach(var abc in task1v.Born1986()){
            //     Console.WriteLine(abc);
            // }

            // foreach(var abc in task1vi.LinusTips()){
            //     Console.WriteLine(abc);
            // }

            // foreach(var abc in task2i.BuyFebruary()){
            //     Console.WriteLine(abc);
            // }

            // int sum = 0;
            // foreach(var abc in task2ii.BuyAri()){
            //     sum += abc;
            // }
            // Console.WriteLine(sum);

            foreach(var abc in task2iii.GrandLow()){
                Console.WriteLine(abc);
            }
        }
    }
}
