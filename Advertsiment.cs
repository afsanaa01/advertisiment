using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp46
{
    class Advertsiment:IComparable
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string SellerName { get; set; }

        public Advertsiment(string name, int price, string sellername)
        {
            Name = name;
            Price = price;
            SellerName = sellername;
        }

        public Advertsiment()
        {

        }

        public string GetInfo()
        {
            return $"{Name} {Price} {SellerName}";
        }

        public int CompareTo(object obj)
        {
            return Price.CompareTo(((Advertsiment)obj).Price);
        }


        public static bool operator <(Advertsiment ad1, Advertsiment ad2)
        {
            return ad1.Price < ad2.Price;
        }

        public static bool operator >(Advertsiment ad1, Advertsiment ad2)
        {
            return ad1.Price > ad2.Price;
        }
        

    }
        enum Categories
        {
            Tecnologies, School, Clothes
        }

}
