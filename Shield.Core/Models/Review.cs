namespace Shield.Core.Models
{
    using Shield.Core.Enums;
    using System.Collections.Generic;
    public class Review
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public ElementalAttribute Attribute { get; set; }
        public List<string> Comments { get; set; }
        public int Dungeon { get; set; }
        public int GuildOffense { get; set; }
        public int GuildDefense { get; set; }
        public int ArenaOffense { get; set; }
        public int ArenaDefense { get; set; }
        public int TowerOfAscension { get; set; }
    }
}
