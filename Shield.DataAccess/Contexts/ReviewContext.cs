namespace Shield.DataAccess.Contexts
{
    using Core.Models.Monster;
    using System.Data.Entity;

    public class ReviewContext : DbContext
    {
        public DbSet<Review> Reviews { get; set; }
    }
}
