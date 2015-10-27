namespace Shield.Core.Models.Monster
{
    using Enums;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Identity
    {
        #region Constructors
        public Identity()
        {
            Abilities = new List<Ability>();
            Ratings = new List<Rating>();
        }
        #endregion

        #region Properties
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
                    ArenaDefense = AverageIfCollectionHasElements(Ratings, item => item.ArenaDefense),
                    ArenaOffense = AverageIfCollectionHasElements(Ratings, item => item.ArenaOffense),
                    TowerOfAscension = AverageIfCollectionHasElements(Ratings, item => item.TowerOfAscension),
                    Dungeon = AverageIfCollectionHasElements(Ratings, item => item.Dungeon),
                    GuildDefense = AverageIfCollectionHasElements(Ratings, item => item.GuildDefense),
                    GuildOffense = AverageIfCollectionHasElements(Ratings, item => item.GuildOffense),
                    Id = Id
                };
            }
        }
        #endregion

        private double AverageIfCollectionHasElements(IEnumerable<Rating> items, 
            Func<Rating, double> expression)
        {
            return items.Any() ? items.Average(expression) : 0;
        }
    }
}
