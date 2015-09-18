namespace Shield.DataAccess.Contexts
{
    using Shield.Core.Models;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public class ReviewContext : DbContext
    {
        public ReviewContext() : base ("ReviewContext")
        {
        }

        public DbSet<Review> Reviews {get; set;}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
