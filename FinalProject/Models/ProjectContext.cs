using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class ProjectContext : DbContext
    {
        public ProjectContext()
        {
        }

        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options) { }

        public DbSet<CharacterModel> Characters { get; set; }
        public DbSet<SuggestionQuestionModel> SuggestionQuestion { get; set; }
        public DbSet<TowerModel> Towers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CharacterModel>().HasData(
                new CharacterModel
                {
                    CharacterId = 1,
                    CharName = "Philomena",
                    CharGender = "Genderfluid",
                    CharSpecies = "Young Spirit",
                    CharOrientation = "Pansexual",
                    Image = "images/Philomena.png",
                    Description = "A blood hungry and violent spirit."
                },
                new CharacterModel
                {
                    CharacterId = 2,
                    CharName = "Rocket",
                    CharGender = "Non-Binary, Masculine Leaning",
                    CharSpecies = "Middle-aged Spirit",
                    CharOrientation = "Pansexual, Monogamous",
                    Image = "images/Rocket.jpg",
                    Description = "An upbeat and jovial spirit"
                }

            );

            modelBuilder.Entity<TowerModel>().HasData(
                new TowerModel
                {
                    TowerId = 1,
                    TowerName = "Philomena",
                    TowerType = "Barracks",
                    TowerRange = "Close",
                    TowerDamage = "Physical",
                    TowerDescript = "This tower perodically releases trained soldiers to block the way of oncoming enemies. It has a cooldown timer roughly 45 seconds long"
                },
                new TowerModel
                {
                    TowerId = 2,
                    TowerName = "Rocket",
                    TowerType = "Ranged",
                    TowerRange = "Long",
                    TowerDamage = "Magic",
                    TowerDescript = "This tower periodcally shoots enemies with magical attacks(unspecified and undecided at this time) they have to charge up attacks but are otherwise a basic tower. They have a 8 second cooldown timer"
                }
            );

            modelBuilder.Entity<SuggestionQuestionModel>().HasData(
                    new SuggestionQuestionModel
                    {
                        QuesSugesId = 1,
                        Name = "John",
                        Subject = "Your Game",
                        QuesSuges = "It has great potential!"
                    },
                     new SuggestionQuestionModel
                     {
                         QuesSugesId = 2,
                         Name = "NarutoRockz",
                         Subject = "cat girls",
                         QuesSuges = "when?"
                     }
            );
        }
    }
}
