using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler_Prototype.Models
{
    public class Events
    {
        public int eventID {  get; set; }
        public DateTime startDateTime { get; set; }
        public TimeSpan Duration { get; set; }
        public int taskID { get; set; }
        public int studyID { get; set; }
        public int techID { get; set; }
        public string studyNum { get; set; }
        public string type { get; set; }
        public int eventCount { get; set; }

        public string comments { get; set; }

        public Events() { }

        // Made this constructor for ConvertDataRowToEvent method in Scheduler class
        public Events(int eventID, DateTime startDateTime, TimeSpan Duration)
        {
            this.eventID = eventID;
            this.startDateTime = startDateTime;
            this.Duration = Duration;
        }
        

    }
}
