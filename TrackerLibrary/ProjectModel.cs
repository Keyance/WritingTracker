using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class ProjectModel
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public int WordsNeeded { get; set; }
        public int WordsNow { get; set; }

        public double AverageNeeded { get; set; }
        public double AverageNow { get; set;}

        public List<DayModel> Days { get; set; } = new List<DayModel>();
    }
}
