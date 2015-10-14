namespace Shield.Core.Models.Monster
{
    using Enums;
    using System.Collections.Generic;

    public class Identity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public ElementalAttribute Attribute { get; set; }
        public List<Ability> Abilities { get; set; }
    }
}
