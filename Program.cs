﻿using System.IO;
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
            var task1vii = new AugustArticle();

            var task2i = new purchaseFebruary();
            var task2ii = new PurchaseAri();
            var task2iii = new GrandPrice();
            

            // Console.WriteLine(task1i.UserNoPhone());
            // Console.WriteLine(task1ii.UserArticles());
            // Console.WriteLine(task1iii.NameAnnis());
            // Console.WriteLine(task1iv.Year2020());
            // Console.WriteLine(task1v.Born1986());
            // Console.WriteLine(task1vi.LinusTips());
            // Console.WriteLine(task1vii.BeforeAugust());

            // Console.WriteLine(task2i.BuyFebruary());
            Console.WriteLine(task2ii.BuyAri());
            // Console.WriteLine(task2iii.GrandLow());

            // Console.WriteLine(task2iii.GrandLow());
            // MeetingRoom.HasItems();
            // ElectronicDevices.HasElectronic();
            // Furnitures.HasFurnitures();
            // PurchasedAt.HasPurchased();
            // ItemBrown.HasBrown();
        }
    }
}
