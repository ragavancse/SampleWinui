using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWinui.Model
{
    public class Monitor
    {
        public string RunningProcessId { get; set; }
        public string RunningActivity { get; set; }
        public string Started { get; set; }
        public string Ended { get; set; }
        public string Type { get; set; }
        public string Id { get; set; }
        public string Description { get; set; }
        public string FailedTask { get; set; }
        public string Status { get; set; }
    }
}
