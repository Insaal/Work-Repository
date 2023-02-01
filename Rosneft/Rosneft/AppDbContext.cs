using System.Data.Entity;
using Rosneft.Domain.Entities;

namespace Rosneft.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }


    public class AppDbContext : DbContext
    {
        public AppDbContext()
            : base("DbConnection")
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new Users
            {

            });
        }


        public DbSet<User> Users { get; set; }

    }
}
