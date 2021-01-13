using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents what place this prize should be.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents the place name.
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Represents the prize amount.
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents the Prize Percentage.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
