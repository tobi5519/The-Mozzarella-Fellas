using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using The_Mozzarella_Fellas.Models;

namespace The_Mozzarella_Fellas.DAL
{
    public class PizzaContext : DbContext
    {

        public PizzaContext() : base("PizzaContext")
        {
        }

        public DbSet<Pizza> Pizzas { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}