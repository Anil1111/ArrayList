using System;

using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            // create instance of array list
            ArrayList list = new ArrayList();
            // add the first name to the array list
            list.Add("John Doe");
            // add a new name to array list
            list.Add("Jane Doe");
            // add the name "Sometone Else"
            list.Add("Someone Else");
             list.Add(123);
            list.Add(501.56);
            list.Add(true);
            list.Add(char.MaxValue);
            // for loop
            foreach (var name in list)
            {
                // print the name
                Console.WriteLine(name);
                // end 
            }
            Console.ReadLine();
        }
    }
}
