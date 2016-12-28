using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableExampleApp {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("======Hash Table=========");
            Hashtable hashTable = new Hashtable();
            hashTable.Add(1, 300);
            hashTable.Add(4, 350);
            hashTable.Add("BITM", ".NET");
            foreach (DictionaryEntry dictionaryEntry in hashTable) {
                Console.WriteLine(dictionaryEntry.Key + "=> " + dictionaryEntry.Value);
            }

            bool isExistKey = hashTable.ContainsKey("BITM");
            bool isExistValue = hashTable.ContainsValue(".NE");
            Console.WriteLine(isExistKey);
            Console.WriteLine(isExistValue);

            Console.WriteLine();
            Console.WriteLine("======Dictionary=========");
            Dictionary<int,string> items=new Dictionary<int, string>();
            items.Add(1, "55");
            items.Add(2, "05");
            items.Add(3, "505");
            items[2] = "BITM";
            items[5] = "Sumon";
            isExistKey = items.ContainsKey(5);
            isExistValue = items.ContainsValue("SUmon");
            Console.WriteLine(isExistKey);
            Console.WriteLine(isExistValue);
            foreach (KeyValuePair<int,string> keyValuePair in items)
            {
                Console.WriteLine(keyValuePair.Key+"=> "+keyValuePair.Value);
            }
            Console.ReadKey();
        }
    }
}
