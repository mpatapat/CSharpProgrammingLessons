using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Cust cust1 = new Cust() { ID = 101, Name = "Mark", Salary = 500 };
            Cust cust2 = new Cust() { ID = 102, Name = "Mark", Salary = 6000 };
            Cust cust3 = new Cust() { ID = 103, Name = "Mark", Salary = 7000 };

            List<Cust> lstCustomer = new List<Cust>(1);
            lstCustomer.Add(cust1);
            lstCustomer.Add(cust2);
            lstCustomer.Add(cust3);

            foreach (Cust c in lstCustomer)
            {
                Console.WriteLine("ID: {0},Name: {1}, Salary: {2}",c.ID,c.Name,c.Salary);
            }

            for (int i = 0; i < lstCustomer.Count; i++)
            {
                Cust c = lstCustomer[i];
                Console.WriteLine("ID: {0},Name: {1}, Salary: {2}", c.ID, c.Name, c.Salary);
            }

            // inset item at the collection
            lstCustomer.Insert(0, cust3);
            foreach (Cust c in lstCustomer)
            {
                Console.WriteLine("ID: {0},Name: {1}, Salary: {2}", c.ID, c.Name, c.Salary);
            }

            Console.WriteLine(lstCustomer.IndexOf(cust3));

            if (lstCustomer.Contains(cust3))
            {
                Console.WriteLine("Found");
            } else
            {
                Console.WriteLine("Not Found:");
            }

            if (lstCustomer.Exists(cxt => cxt.Name.StartsWith("P")))
            {
                Console.WriteLine("Found P");

            } else
            {
                Console.WriteLine("Not Found P");

            }
            // Contains and Exist return a boolean Type value
            // Find and FindLast return the object itself
            // FindAll return all list of items based on the given condition
            // FindIndex return the number of the index
            // FindLastIndex

            Cust x = lstCustomer.Find(c => c.Salary > 1000);
            Console.WriteLine("ID: {0},Name: {1}, Salary: {2}", x.ID, x.Name, x.Salary);

            lstCustomer.FindIndex(xx => xx.Salary > 1000);
            lstCustomer.Clear();

            Cust[] custArray = new Cust[3];
            custArray[0] = cust1;
            custArray[1] = cust2;
            custArray[2] = cust3;

            lstCustomer = custArray.ToList();
            

            foreach (Cust c in lstCustomer)
            {
                Console.WriteLine("Array Converted to List entries - > ID: {0},Name: {1}, Salary: {2}", c.ID, c.Name, c.Salary);
            }

            // Convert list to an Array

            custArray = lstCustomer.ToArray();
            foreach (Cust c in custArray)
            {
                Console.WriteLine("List to Array - > ID: {0},Name: {1}, Salary: {2}", c.ID, c.Name, c.Salary);

            }

            // Convert List items to Dictionary

            Dictionary<int, Cust> ListToDictionary = lstCustomer.ToDictionary(x => x.ID, x => x);
            foreach (KeyValuePair<int,Cust> kpv in ListToDictionary)
            {
                Cust c = kpv.Value;
                Console.WriteLine("List to Dictionary - > ID: {0},Name: {1}, Salary: {2}", c.ID, c.Name, c.Salary);
            }

        }
    }
    public class Cust
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
