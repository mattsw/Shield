namespace Shield.Core.Models.Monster
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Ability
    {
        [Key]
        public int AbilityId { get; set; }
        [Required]
        public Identity Identity { get; set; }
        public int IdentityId { get; set; }
        public int SkillSlot { get; set; }
        public string Description { get; set; }
    }
}
