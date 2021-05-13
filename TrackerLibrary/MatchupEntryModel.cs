using System;
namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Represents one team in the matchup.
        /// </summary>

        public double Score { get; set; }
        /// <summary>
        /// Represents the score for the particular team.
        /// </summary>

        public MatchupModel ParentMatchup { get; set; }
        /// <summary>
        /// Represents the matchup that this team came from as the winner.
        /// </summary>
    }
}
