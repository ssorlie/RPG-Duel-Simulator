using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RPG_Duel_Simulator.Models
{
    public class Character
    {
        [Key]
        public int CharacterId { get; set; }
        [Required]
        [DisplayName("Character name")]
        public string CharacterName { get; set; }
        [Required]
        [DisplayName("Race / Class")]
        public string CharacterType { get; set; }
        [Required]
        [DisplayName("Level")]
        [Range(1, 50, ErrorMessage = "Level needs to be from 1 to 50!")]
        public int Level { get; set; }
        [Required]
        [DisplayName("STR - Strength")]
        [Range(1, 100, ErrorMessage = "Strength needs to be from 1 to 100!")]
        public int Str { get; set; }
        [Required]
        [DisplayName("INT - Intelligence")]
        [Range(1, 100, ErrorMessage = "Intelligence needs to be from 1 to 100!")]
        public int Intl { get; set; }
        [Required]
        [DisplayName("WIL - Willpower")]
        [Range(1, 100, ErrorMessage = "Willpower needs to be from 1 to 100!")]
        public int Wil { get; set; }
        [Required]
        [DisplayName("AGL - Agility")]
        [Range(1, 100, ErrorMessage = "Agility needs to be from 1 to 100!")]
        public int Agl { get; set; }
        [Required]
        [DisplayName("SPD - Speed")]
        [Range(1, 100, ErrorMessage = "Speed needs to be from 1 to 100!")]
        public int Spd { get; set; }
        [Required]
        [DisplayName("END - Endurance")]
        [Range(1, 100, ErrorMessage = "Endurance needs to be from 1 to 100!")]
        public int End { get; set; }
        [Required]
        [DisplayName("PER - Personality")]
        [Range(1, 100, ErrorMessage = "Personality needs to be from 1 to 100!")]
        public int Per { get; set; }
        [Required]
        [DisplayName("Luck")]
        [Range(1, 100, ErrorMessage = "Luck needs to be from 1 to 100!")]
        public int Luck { get; set; }
        [Required]
        [DisplayName("Equipment quality")]
        [Range(1, 100, ErrorMessage = "The quality of equipment needs to be from 1 to 100!")]
        public int Equipment { get; set; }
        [DisplayName("Character description")]
        [Column(TypeName = "VARCHAR(300)")]
        public string? CharacterDescription { get; set; }
    }
}
