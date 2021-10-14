using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp46
{
    static class Extension
    {
        public static int Sum(this Advertsiment[] array, int common=0)
        {
            foreach (var item in array)
            {
                common += item.Price;
            }

            return common;
        }
    }
}
