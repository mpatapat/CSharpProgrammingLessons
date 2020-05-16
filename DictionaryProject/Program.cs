using System;
using System.Collections.Generic;

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

            foreach ()
            {

            }

           // Console.WriteLine("Hello World!");
        }
    }

    public class Cust
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }

}
