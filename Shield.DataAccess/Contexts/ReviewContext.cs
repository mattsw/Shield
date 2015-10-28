namespace Shield.DataAccess.Contexts
{
    using Core.Models.Monster;
    using System.Data.Entity;

    public class ReviewContext : DbContext
    {
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Ability> Abilities { get; set; }
    }
}
