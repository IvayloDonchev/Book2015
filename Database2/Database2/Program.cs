﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using static System.Console;


namespace Database2
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual string CompanyName { get; set; }
        [Key] public int CustomerID { get; set; }
    }
    public class Address
    {
        public string City { get; set; }
        public string Country { get; set; }
        public virtual string CompanyName { get; set; }
        [Key] public int AddressID { get; set; }
    }
    public class CustomerContext : DbContext
    {
        //public CustomerContext() : base("Data Source = SONY, 49170;" + 
        //                                "Initial Catalog = Customers List;" +
        //                                "Integrated Security = True") { }
        public CustomerContext() : base("Data Source = K3-501-2, 49170;" +
                                        "Initial Catalog = Customers List;" +
                                        "Integrated Security = True")
        { }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new CustomerContext())
            {
                //Customer customer1 = new Customer { FirstName = "Kim", LastName = "Abercrombie", CompanyName = "Alpine Ski House" };
                //db.Customers.Add(customer1);
                //db.Customers.Add(new Customer { FirstName = "Jeff", LastName = "Hay", CompanyName = "Coho Winery"});
                //db.Customers.Add(new Customer { FirstName = "Charlie", LastName = "Herb", CompanyName = "Alpine Ski House" });
                //db.Customers.Add(new Customer { FirstName = "Ivaylo", LastName = "Donchev", CompanyName = "Trey Research" });

                //db.Addresses.Add(new Address { CompanyName = "Alpine Ski House", City = "Berne", Country = "Switzerland" });
                //db.Addresses.Add(new Address { CompanyName = "Coho Winery", City = "San Francisco", Country = "United States" });
                //db.Addresses.Add(new Address { CompanyName = "Trey Research", City = "New York", Country = "United States" });
                
                //db.SaveChanges();

                var query = from c in db.Customers orderby c.FirstName, c.LastName
                            join adr in db.Addresses
                            on c.CompanyName equals adr.CompanyName into g
                            from d in g
                            select new { d.CompanyName, d.City, d.Country };
                var refined_results = query.Distinct(); //премахва повтарящите се записи
                foreach (var x in refined_results )
                {
                    WriteLine($"Company: {x.CompanyName}, Address: {x.City}, {x.Country}");
                }
                WriteLine("Press any key!");
                ReadKey();
            }
        }
    }
}
