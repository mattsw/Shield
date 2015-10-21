namespace Shield.Core.Models.Monster
{
    using Enums;
    using System.Collections.Generic;
    using System.Linq;

    public class Identity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public ElementalAttribute Attribute { get; set; }
        public List<Ability> Abilities { get; set; }
        public List<Rating> Ratings { get; set; }
        public Rating AverageRating {
            get
            {
                return new Rating
                {
                    ArenaDefense = Ratings.Average(item => item.ArenaDefense),
                    ArenaOffense = Ratings.Average(item => item.ArenaOffense),
                    TowerOfAscension = Ratings.Average(item => item.TowerOfAscension),
                    Dungeon = Ratings.Average(item => item.Dungeon),
                    GuildDefense = Ratings.Average(item => item.GuildDefense),
                    GuildOffense = Ratings.Average(item => item.GuildOffense),
                    Id = Id
                };
            }
        }
    }
}
