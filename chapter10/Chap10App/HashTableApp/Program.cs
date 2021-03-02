using System;
using System.Collections;

namespace HashTableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HashTable 예제 !");

            Hashtable ht = new Hashtable();
            ht["일"] = "one";
            ht["이"] = "two";
            ht["삼"] = "three";
            ht["사"] = "four";

            Console.WriteLine(ht["일"]);  // one
            Console.WriteLine(ht["이"]);  // two
            Console.WriteLine(ht["사"]);  // four



            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine($"{item.Key} : {item.Value}"); 
            }
        }
    }
}
