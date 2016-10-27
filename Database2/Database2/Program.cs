using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
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
        public CustomerContext() : base("Customers List") { }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new CustomerContext())
            {
                Customer customer1 = new Customer { FirstName = "Kim", LastName = "Abercrombie", CompanyName = "Alpine Ski House" };
                db.Customers.Add(customer1);
                db.Customers.Add(new Customer { FirstName = "Jeff", LastName = "Hay", CompanyName = "Coho Winery"});
                db.Customers.Add(new Customer { FirstName = "Charlie", LastName = "Herb", CompanyName = "Alpine Ski House" });

                db.Addresses.Add(new Address { CompanyName = "Alpine Ski House", City = "Berne", Country = "Switzerland" });
                db.Addresses.Add(new Address { CompanyName = "Coho Winery", City = "San Francisco", Country = "United States" });
                db.Addresses.Add(new Address { CompanyName = "Trey Research", City = "New York", Country = "United States" });
                
                db.SaveChanges();

                var query = db.Customers.Select(c => c.CompanyName).Distinct();
                //var query = from c in db.Customers
                //            orderby c.FirstName, c.LastName
                //            select c;
                foreach(var x in query )
                {

                    var findAddress = from a in db.Addresses
                                      where a.CompanyName == x
                                      select a;
                    foreach (var a in findAddress)
                        WriteLine($"Company {x}, Address: {a.City}, {a.Country}");

                }
                   
                WriteLine("Press any key!");
                ReadKey();
            }
        }
    }
}
