using Com.Okmer.DynamicTypes;
using System;
using System.Collections.Generic;

namespace SampleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicBag shoppingBag = new DynamicBag();
            DynamicBag spareBag = new DynamicBag();

            shoppingBag.Add("spareBag", spareBag);
            shoppingBag.Add("shoppingList", new string[] { "eggs", "milk", "cheese" });

            spareBag.Add("carCoin", "50ct");
            spareBag.Add("carValue", 50);

            Print(shoppingBag);

            Console.Write("---------------------------> ENTER <----: ");
            Console.ReadLine();

            shoppingBag.ToBinaryFile("shoppingBag.bin");

            DynamicBag shoppingBagFromBinaryFile = DynamicBag.FromBinaryFile("shoppingBag.bin");

            Print(shoppingBagFromBinaryFile);

            Console.Write("---------------------------> ENTER <----: ");
            Console.ReadLine();
        }

        private static void Print(DynamicBag bag)
        {
            Console.WriteLine("BAG BEGIN");
            foreach (string key in bag.Keys)
            {
                Console.WriteLine(key + ": ");
                Print(bag[key]);
            }
            Console.WriteLine("BAG END");
        }

        private static void Print(IEnumerable<dynamic> values)
        {
            Console.WriteLine("ENUMERABLE BEGIN");
            foreach (dynamic value in values)
            {
                Print(value);
            }
            Console.WriteLine("ENUMERABLE END");
        }

        private static void Print(bool value) => Console.WriteLine("bool -> " + value.ToString());

        private static void Print(int value) => Console.WriteLine("int -> " + value.ToString());

        private static void Print(double value) => Console.WriteLine("double -> " + value.ToString());

        private static void Print(string value) => Console.WriteLine("string -> " + value.ToString());

        private static void Print(object value) => Console.WriteLine("object-> " + value.ToString());
    }
}
