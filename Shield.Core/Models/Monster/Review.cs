namespace Shield.Core.Models.Monster
{
    using Shield.Core.Enums;
    using System.Collections.Generic;
    public class Review
    {
        public Identity MonsterIdentity { get; set; }
        public Rating AverageRating { get; set; }
        //TODO Consider whether or not these comments can be liked / disliked to show only relevant comments at the top
        public List<string> Comments { get; set; }
    }
}
