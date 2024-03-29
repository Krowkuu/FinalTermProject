﻿// <auto-generated />
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FinalProject.Migrations
{
    [DbContext(typeof(ProjectContext))]
    partial class ProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FinalProject.Models.CharacterModel", b =>
                {
                    b.Property<int>("CharacterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CharGender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CharName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CharOrientation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CharSpecies")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CharacterId");

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            CharacterId = 1,
                            CharGender = "Genderfluid",
                            CharName = "Philomena",
                            CharOrientation = "Pansexual",
                            CharSpecies = "Young Spirit",
                            Description = "A blood hungry and violent spirit.",
                            Image = "images/Philomena.png"
                        },
                        new
                        {
                            CharacterId = 2,
                            CharGender = "Non-Binary, Masculine Leaning",
                            CharName = "Rocket",
                            CharOrientation = "Pansexual, Monogamous",
                            CharSpecies = "Middle-aged Spirit",
                            Description = "An upbeat and jovial spirit",
                            Image = "images/Rocket.jpg"
                        });
                });

            modelBuilder.Entity("FinalProject.Models.SuggestionQuestionModel", b =>
                {
                    b.Property<int>("QuesSugesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuesSuges")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuesSugesId");

                    b.ToTable("SuggestionQuestion");

                    b.HasData(
                        new
                        {
                            QuesSugesId = 1,
                            Name = "John",
                            QuesSuges = "It has great potential!",
                            Subject = "Your Game"
                        },
                        new
                        {
                            QuesSugesId = 2,
                            Name = "NarutoRockz",
                            QuesSuges = "when?",
                            Subject = "cat girls"
                        });
                });

            modelBuilder.Entity("FinalProject.Models.TowerModel", b =>
                {
                    b.Property<int>("TowerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TowerDamage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TowerDescript")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TowerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TowerRange")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TowerType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TowerId");

                    b.ToTable("Towers");

                    b.HasData(
                        new
                        {
                            TowerId = 1,
                            TowerDamage = "Physical",
                            TowerDescript = "This tower perodically releases trained soldiers to block the way of oncoming enemies. It has a cooldown timer roughly 45 seconds long",
                            TowerName = "Philomena",
                            TowerRange = "Close",
                            TowerType = "Barracks"
                        },
                        new
                        {
                            TowerId = 2,
                            TowerDamage = "Magic",
                            TowerDescript = "This tower periodcally shoots enemies with magical attacks(unspecified and undecided at this time) they have to charge up attacks but are otherwise a basic tower. They have a 8 second cooldown timer",
                            TowerName = "Rocket",
                            TowerRange = "Long",
                            TowerType = "Ranged"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
