using System;

namespace ConsoleApp46
{
    class Program
    {
        static void Main(string[] args)
        {
            Advertsiment a1 = new Advertsiment("Phone", 350, "Afsana");
            Advertsiment a2 = new Advertsiment("Notebook", 90, "Xadice");
            Advertsiment a3 = new Advertsiment("Suit", 250, "Fatime");

            Advertsiment[] ads = { a1, a2, a3 };

            Advertsiment[] ad = { a1, a2, a3 };

            try
            {
                Array.Sort(ads);
            }
            catch (Exception)
            {
                Console.WriteLine("Array sort oluna bilmir");
            }

            foreach (Advertsiment item in ads)
            {
                Console.WriteLine(item.GetInfo());
            }

            Console.WriteLine(a1 < a2);

            Console.WriteLine(ad.Sum());     
        }      
    }
}
