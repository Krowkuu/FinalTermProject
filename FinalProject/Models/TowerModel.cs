using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class TowerModel
    {   [Key]
        public int TowerId          { get; set; }
        public string TowerName     { get; set; }
        public string TowerType     { get; set; }
        public string TowerRange    { get; set; }
        public string TowerDamage   { get; set; }
        public string TowerDescript { get; set; }
    }
}
