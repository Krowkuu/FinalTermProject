using System;
using Microsoft.EntityFrameworkCore;
using Xunit;
using FinalProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace FinalProjectTests
{
    public class UnitTest1
    {
        ProjectContext cntxt;
        CharacterModel cha;
        List<CharacterModel> charas;
        SuggestionQuestionModel sugQue;
        List<SuggestionQuestionModel> sugques;
        TowerModel tower;
        List<TowerModel> towers;
        

        [Fact]
        public void CanAccessDatabases()
        {


            charas = cntxt.Characters.OrderBy(cha => cha.CharacterId).ToList();
            Assert.Equal(2, charas.Count);
        }
    }
}
