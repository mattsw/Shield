namespace Shield.Core.Models.Monster
{
    using System.Collections.Generic;

    public class Review
    {
        public int ReviewId { get; set; }
        public Identity MonsterIdentity { get; set; }
        public int IdentityId { get; set; }
        //TODO Consider whether or not these comments can be liked / disliked to show only relevant comments at the top
        public List<string> Comments { get; set; }
    }
}
