namespace Shield.Core.Models.Monster
{
    using System.ComponentModel.DataAnnotations;

    public class Rating
    {
        public int Id { get; set; }
        [Required]
        public Identity Identity { get; set; }
        public double Dungeon { get; set; }
        public double GuildOffense { get; set; }
        public double GuildDefense { get; set; }
        public double ArenaOffense { get; set; }
        public double ArenaDefense { get; set; }
        public double TowerOfAscension { get; set; }
    }
}
