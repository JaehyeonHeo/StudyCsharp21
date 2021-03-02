﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> pairs = new Dictionary<int, string>();
            pairs[1] = "one";
            pairs[2] = "two";
            pairs[3] = "three";
            pairs[4] = "four";
            pairs[5] = "five";

            foreach (var item in pairs)
            {
                Console.WriteLine($"{item.Key} : {item.Value}"); 
            }

            Dictionary<string, string> pairs2 = new Dictionary<string, string>();
            pairs2["일"] = "one";
            pairs2["이"] = "two";
            pairs2["삼"] = "three";
            pairs2["사"] = "four";
            pairs2["오"] = "five";

            foreach (var item in pairs2)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }
}
