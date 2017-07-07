using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
public 	class PersonContext : DbContext
	{

		public PersonContext()
            : base("name=PersonContext")
        {
		}
		public DbSet<Person> People { get; set; }
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Admin>().ToTable("Admins");
			modelBuilder.Entity<Client>().ToTable("Clients");
		}
	}
}
