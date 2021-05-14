using System;
using System.Collections.Generic;
namespace TrackerLibrary
{
    public class MatchupModel
    {
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// The set of teams that were involved in this match.
        /// </summary>

        public TeamModel Winner { get; set; }
        /// <summary>
        /// The winner of the match.
        /// </summary>

        public int MatchupRound { get; set; }
        /// <summary>
        /// Which round this match is part of.
        /// </summary>
    }
}
