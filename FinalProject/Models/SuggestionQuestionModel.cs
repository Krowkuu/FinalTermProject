using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class SuggestionQuestionModel
    {
        [Key]
        public int QuesSugesId  { get; set; }
        public string Name      { get; set; }
        public string Subject   { get; set; }
        public string QuesSuges { get; set; }
    }
}
