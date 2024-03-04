using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class ProjectModel
    {
        /// <summary>
        /// The name given to concrete project.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The description of the project, can be the plot, genre etc.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The number of words that the user wants to write in this project.
        /// </summary>
        public int WordsNeeded { get; set; }
        /// <summary>
        /// The number of words that the user has writen in the project so far.
        /// </summary>
        public int WordsNow { get; set; }

        /// <summary>
        /// The average number of words per day, that the user should write in order to finish the project in time.
        /// </summary>
        public double AverageNeeded { get; set; }
        /// <summary>
        /// The average number of words per day that the user has written so far.
        /// </summary>
        public double AverageNow { get; set;}

        /// <summary>
        /// A List of Days that belong to a concrete project.
        /// </summary>
        public List<DayModel> Days { get; set; } = new List<DayModel>();
    }
}
