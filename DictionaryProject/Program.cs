using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Linq;

namespace DictionaryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Cust cust1 = new Cust() { ID = 101, Name = "Mark", Salary = 500};
            Cust cust2 = new Cust() { ID = 102, Name = "Mark", Salary = 6000 };
            Cust cust3 = new Cust() { ID = 103, Name = "Mark", Salary = 7000};

            Dictionary<int, Cust> DictCust = new Dictionary<int, Cust>();

            DictCust.Add(cust1.ID,cust1);
            DictCust.Add(cust2.ID, cust2);
            DictCust.Add(cust3.ID, cust3);

            Cust outCust = DictCust[103];
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}",outCust.ID,outCust.Name,outCust.Salary);

            foreach (KeyValuePair<int,Cust> custValuePair in DictCust)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", custValuePair.Value.ID,custValuePair.Value.Name,custValuePair.Value.Salary);
            }

            if (!DictCust.ContainsKey(cust1.ID))
            {
                DictCust.Add(cust1.ID, cust1);
            }

            // Console.WriteLine("Hello World!")
            /*
             * 1. TryGetValue()
             * 2. Count()
             * 3. Remove()
             * 4. Clear()
             * 5. Using LINQ extension methods with Dictionary
             * 6. Different ways to convert an array into a dictionary
             */

            if (DictCust.TryGetValue(101,out outCust))
            {
                Console.WriteLine("ID = {0},",outCust.ID);
            }

            Console.WriteLine("Total Customer {0}",DictCust.Count());
            Console.WriteLine("Customer Salary greater than 1000 is equal to : {0}",DictCust.Count(kvp => kvp.Value.Salary > 1000));

            // Convert an array to Dictionary

            Cust[] custArray = new Cust[3];
            custArray[0] = cust1;
            custArray[1] = cust2;

            custArray.ToDictionary(cst => cst.ID, cst => cst);
        }
    }

    public class Cust
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }

}
