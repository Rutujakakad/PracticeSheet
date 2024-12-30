// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
namespace StudentGrade
{
    class Order
    {
        //Q.18)Manage a list of orders and group them by product category. Calculate the total sales for each category.
        public int OrderId { get; set; }
        public string ProductCategory { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        static void Main(string[] args)
        {
            List<Order> order = new List<Order>
            {
                new Order { OrderId = 1, ProductCategory = "Electronics", ProductName = "Laptop", Quantity = 3, Price = 900 },
                new Order { OrderId = 2, ProductCategory = "Electronics", ProductName = "Phone", Quantity = 2, Price = 700 },
                new Order { OrderId = 3, ProductCategory = "Books", ProductName = "Novel", Quantity = 5, Price = 50 },
                new Order { OrderId = 4, ProductCategory = "Books", ProductName = "Drama", Quantity = 5, Price = 30 }
            };

            var salesByCategory = order.GroupBy(y => y.ProductCategory).ToList();
            //TotalSales = Quantity * PricePerUnit)

            Console.WriteLine("Sales by Category:");
            foreach(var sales in salesByCategory)
            {
                Console.WriteLine(sales);//category and total sale(how to print both)
            }



        }
    }
}
