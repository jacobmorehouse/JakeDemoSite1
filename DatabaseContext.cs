using Microsoft.EntityFrameworkCore;
using JakeDemoSite1.Models;

namespace JakeDemoSite1.Data
{
	public class DatabaseContext : DbContext
	{
		public DatabaseContext(DbContextOptions<DatabaseContext> options) :base(options) { }


		//This is where you add the classes that are used by EF. 

		public DbSet<Models.Employees> Employees { get; set; }
		public DbSet<Categories> Categories { get; set; }
		public DbSet<CustomerDemographics> CustomerDemographics { get; set; }
		public DbSet<Customers> Customers { get; set; }




		public DbSet<EmployeeTerritories> EmployeeTerritories { get; set; }
		public DbSet<OrderDetails> OrderDetails { get; set; }
		public DbSet<Orders> Orders { get; set; }
		public DbSet<Products> Products { get; set; }
		public DbSet<Regions> Regions { get; set; }
		public DbSet<Shippers> Shippers { get; set; }
		public DbSet<Suppliers> Suppliers { get; set; }
		public DbSet<Territories> Territories { get; set; }



	}
}
