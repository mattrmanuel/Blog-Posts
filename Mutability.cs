using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Fred";
            // name[0] = "K"; --> throws error

            Console.WriteLine(name); // Fred

            List<int> newList = new List<int>() { 1, 2, 3 };

            newList[0] = 5;

            Console.WriteLine(newList[0]); // Prints "5"

            newList.Add(12);

            Console.WriteLine("The size of the list is {0} and the last " +
                "element is {1}", newList.Count,newList[newList.Count-1]);

            newList.RemoveAt(3);

            Console.WriteLine("The size of the list is {0} and the last " +
                "element is {1}", newList.Count, newList[newList.Count - 1]);

        }
    }
}
