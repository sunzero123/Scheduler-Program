using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler_Prototype.Models
{
    internal class Technicians
    {
        public int techID {  get; set; }
        public int techEmpNum { get; set; }
        public string techFirstName { get; set; }
        public string techLastName { get; set; }
        public string techNickname { get; set; }
        public string techEmail { get; set; }
        public string initials { get; set; }
    }
}
