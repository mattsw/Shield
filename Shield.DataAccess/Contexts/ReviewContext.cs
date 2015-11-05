namespace Shield.DataAccess.Contexts
{
    using Core.Models.Monster;
    using System.Data.Entity;

    public class ReviewContext : DbContext
    {
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }
        public virtual DbSet<Ability> Abilities { get; set; }
    }
}
