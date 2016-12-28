using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkApp {
    class Program {
        static void Main(string[] args) {
            Hashtable hashTable = new Hashtable();
            do {
                Console.WriteLine("Enter Department Code");
                var depcode = Console.ReadLine();
                if (depcode.Length < 3) {
                    Console.WriteLine("Enter at least 3 character");
                    break;
                }
                if (hashTable.ContainsKey(depcode)) {
                    Console.WriteLine("Already exist " + depcode);
                    break;
                }
                Console.WriteLine("Enter Department Name");
                var depname = Console.ReadLine();
                if (hashTable.ContainsValue(depname)) {
                    Console.WriteLine("Already exist " + depname);
                    break;
                }
                hashTable.Add(depcode, depname);
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            Console.WriteLine();
            Console.WriteLine("Total Department: " + hashTable.Count);
            Console.WriteLine();
            Console.WriteLine("Department Code" + "  " + "Department Name");
            Console.WriteLine("===============" +" "+"================");
            foreach (DictionaryEntry dictionaryEntry in hashTable) {

                Console.WriteLine(dictionaryEntry.Key + "              " + dictionaryEntry.Value);
            }
            Console.ReadKey();
        }
    }
}
