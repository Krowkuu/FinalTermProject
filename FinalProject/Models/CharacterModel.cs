using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class CharacterModel
    {
         [Key]
        public int CharacterId        { get; set; }
        public string CharName        { get; set; }
        public string CharGender      { get; set; }
        public string CharSpecies     { get; set; }
        public string CharOrientation { get; set; }
        public string Image           { get; set; }
        public string Description     { get; set; }
    }
}
