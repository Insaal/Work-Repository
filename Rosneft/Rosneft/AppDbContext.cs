using System.Data.Entity;

namespace Rosneft
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

        public DbSet<User> Users { get; set; }

    }
}
