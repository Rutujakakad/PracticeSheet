// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
namespace StudentGrade
{
    //Q.17)Given list of customer records, filter out customers who have made purchases in the last month, and create a new list with their names and total purchase amounts
    class CustomerRecord
    {
        public string Name { get; set; }
        public DateTime PurchaseDate { get; set; }
        public double PurchaseAmount { get; set; }


        static void Main(string[] args)
        {
            List<CustomerRecord> customer = new List<CustomerRecord>
            {
               new CustomerRecord { Name = "Tina", PurchaseDate = DateTime.Now.AddDays(-10), PurchaseAmount = 200.50 },
               new CustomerRecord { Name = "Joseph", PurchaseDate = DateTime.Now.AddDays(-35), PurchaseAmount = 100.00 },
               new CustomerRecord { Name = "Riya", PurchaseDate = DateTime.Now.AddDays(-20), PurchaseAmount = 300.00 }
            };

            var recentCustomer = customer.Where(x => x.PurchaseDate >= lastMonthStartDate).ToList(); //how to  take new list: name and purchase amount
           
            Console.WriteLine("Customers who made purchases in the last month:");
            foreach (var customerRecord in recentCustomer)
            {
                Console.WriteLine($"Name: {customerRecord.Name}, Total Purchase: {customerRecord.PurchaseAmount}");
            }
        }

        public static DateTime currentDate = DateTime.Now;//filter the customer who purchase products in last month
        public static DateTime lastMonthStartDate = currentDate.AddMonths(-1);

    }   

}
  





           
        

            
 

           
     
    
        


