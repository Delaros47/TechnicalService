using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class TechinalServiceContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-4HHFM4J\DEVELOPER;Initial Catalog=DbTechnicalService;Integrated Security=True;");
        }

        public DbSet<Bank> Banks { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ProductAcceptance> ProductAcceptances { get; set; }
        public DbSet<ProductSale> ProductSales { get; set; }
        public DbSet<Tracking> Trackings { get; set; }
        public DbSet<InvoiceInfo> InvoiceInfos { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }




    }
}
