using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler_Prototype.Models
{
    internal class Tasks
    {
        public int taskID {  get; set; }
        public string studyNum { get; set; }
        public int studyID { get; set; }
        public int techID { get; set; }
        public DateTime studyStartDate { get; set; }
        public DateTime studyEndDate { get; set; }
        public DateTime taskStartDate { get; set; }
        public TimeSpan Duration { get; set; }
        public string type { get; set; }
        public string daily_frequency { get; set; }
        public string weekly_frequency { get; set; }
        public int numOccurrences { get; set; }
        public byte[] customDays { get; set; }

        public string comments { get; set; }
       
    }
}
