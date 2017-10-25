using System;
using System.Collections.Generic;
using Monaca.Controllers.Apis;
using Monaca.Models;
using Xunit;

namespace Monaca.Tests
{
    public class TeamControllerTest
    {
        TeamsController controler = new TeamsController();

        [Fact]
        public void QueryTeamListReturnCorrectTeams()
        {
            var teams = new List<Team>(controler.GetTeams());

            Assert.Equal(teams.Count, 2);
        }
    }
}
