using System;
using System.Collections.Generic;

namespace TrackerLibrary
{
    public class TeamModel
    {
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        /// <summary>
        /// A list of people which make the team.
        /// </summary>

        public string TeamName { get; set; }
        /// <summary>
        /// The name of the team.
        /// </summary>
    }
}
