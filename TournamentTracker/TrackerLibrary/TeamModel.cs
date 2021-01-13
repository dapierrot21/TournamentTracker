using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TeamModel
    {
        /// <summary>
        /// Represents a list of players.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>(); //initailize Person

        /// <summary>
        /// Represents the team name.
        /// </summary>
        public string TeamName { get; set; }
    }
}
