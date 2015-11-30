namespace Shield.Core.Models.Monster
{
    using System.ComponentModel.DataAnnotations;

    public class Rating
    {
        //TODO Consider adding another property to rate the ability to perform the "farmer" role
        #region Properties
        [Key]
        public int RatingId { get; set; }
        [Required]
        public Identity Identity { get; set; }
        public int IdentityId { get; set; }
        public double Dungeon { get; set; }
        public double GuildOffense { get; set; }
        public double GuildDefense { get; set; }
        public double ArenaOffense { get; set; }
        public double ArenaDefense { get; set; }
        public double TowerOfAscension { get; set; }
        #endregion
    }
}
