using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// Represent the tournament name.
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Represents the cost of entry fee.
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Represents a list of entered/exisiting teams.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// Represents a list of prizes.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Represents a list within a list of rounds.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
