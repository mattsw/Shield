namespace Shield.Core.Models.Monster
{
    using System.ComponentModel.DataAnnotations;

    public class Ability
    {
        public int Id { get; set; }
        [Required]
        public Identity Identity { get; set; }
        public int SkillSlot { get; set; }
        public string Description { get; set; }
    }
}
