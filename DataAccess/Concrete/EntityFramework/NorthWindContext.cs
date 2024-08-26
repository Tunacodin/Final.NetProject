using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //Context işlemi: Veritabanı tabloları ile bizim ürettiğimiz classları (Product,Customer,Category) bağlamak
    //DbContext EF ile geliyor
    public class NorthWindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-0I24A1AJ\SQLEXPRESS;Database=Northwind;Trusted_Connection=true;TrustServerCertificate=True;");

        }



        //Hangi Class hangi tabloya karşı geliyor
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
