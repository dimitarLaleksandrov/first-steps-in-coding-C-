using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public static class ErrorMeseges
    {
        public const string NullOrWSNameExMessage = "A name should not be empty.";
        public const string StatInvalidvalue = "{0} should be between 0 and 100.";
        public const string PlayerNotInTeam = "Player {0} is not in {1} team.";
        public const string TeamNotExisti = "Team {0} does not exist.";
    }
}
