using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler_Prototype.Models
{
    internal class Studies
    {
        public int studyID {  get; set; }
        public string studyNum {  get; set; }
        public string sponsor {  get; set; }
        public int technicianID { get; set; }
        public string color { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }
}
