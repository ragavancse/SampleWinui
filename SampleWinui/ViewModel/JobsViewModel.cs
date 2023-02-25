using SampleWinui.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWinui.ViewModel
{
    public class JobsViewModel
    {
        public List<Job> Jobs => GetJobs().Skip(4).Take(2).ToList();

        public List<Job> GetJobs()
        {
            return new List<Job>
            {
                new Job{ JobId="2955", JobType= "Multi-Task", Descripton="10- Honor Care Payment Processing (Client) ", Status="Complete" , LastMessage="Succeeded"},
                new Job{ JobId="2955", JobType= "Multi-Task", Descripton="11- Honor Care Payment Processing (Client) ", Status="Complete" , LastMessage="Succeeded"},
                new Job{ JobId="2954", JobType= "Multi-Task", Descripton="10- Address Update ", Status="Idle" , LastMessage="Succeeded"},
                new Job{ JobId="2952", JobType= "Multi-Task", Descripton="10- BackFill Compression ", Status="Idle" , LastMessage="Succeeded"},
                new Job{ JobId="2951", JobType= "Multi-Task", Descripton="Chad Image Test", Status="Complete" , LastMessage="Succeeded"},
                new Job{ JobId="2952", JobType= "Multi-Task", Descripton="Charge Export ", Status="Complete" , LastMessage="Succeeded"},
                 new Job{ JobId="2955", JobType= "Multi-Task", Descripton="10- Honor Care Payment Processing (Client) ", Status="Complete" , LastMessage="Succeeded"},
                new Job{ JobId="2955", JobType= "Multi-Task", Descripton="11- Honor Care Payment Processing (Client) ", Status="Complete" , LastMessage="Succeeded"},
                new Job{ JobId="2954", JobType= "Multi-Task", Descripton="10- Address Update ", Status="Idle" , LastMessage="Succeeded"},
                new Job{ JobId="2952", JobType= "Multi-Task", Descripton="10- BackFill Compression ", Status="Idle" , LastMessage="Succeeded"},
                new Job{ JobId="2951", JobType= "Multi-Task", Descripton="Chad Image Test", Status="Complete" , LastMessage="Succeeded"},
                new Job{ JobId="2952", JobType= "Multi-Task", Descripton="Charge Export ", Status="Complete" , LastMessage="Succeeded"},
                new Job{ JobId="2955", JobType= "Multi-Task", Descripton="10- Honor Care Payment Processing (Client) ", Status="Complete" , LastMessage="Succeeded"},
                new Job{ JobId="2955", JobType= "Multi-Task", Descripton="11- Honor Care Payment Processing (Client) ", Status="Complete" , LastMessage="Succeeded"},
                new Job{ JobId="2954", JobType= "Multi-Task", Descripton="10- Address Update ", Status="Idle" , LastMessage="Succeeded"},
                new Job{ JobId="2952", JobType= "Multi-Task", Descripton="10- BackFill Compression ", Status="Idle" , LastMessage="Succeeded"},
                new Job{ JobId="2951", JobType= "Multi-Task", Descripton="Chad Image Test", Status="Complete" , LastMessage="Succeeded"},
                new Job{ JobId="2952", JobType= "Multi-Task", Descripton="Charge Export ", Status="Complete" , LastMessage="Succeeded"},
                new Job{ JobId="2955", JobType= "Multi-Task", Descripton="10- Honor Care Payment Processing (Client) ", Status="Complete" , LastMessage="Succeeded"},
                new Job{ JobId="2955", JobType= "Multi-Task", Descripton="11- Honor Care Payment Processing (Client) ", Status="Complete" , LastMessage="Succeeded"},
                new Job{ JobId="2954", JobType= "Multi-Task", Descripton="10- Address Update ", Status="Idle" , LastMessage="Succeeded"},
                new Job{ JobId="2952", JobType= "Multi-Task", Descripton="10- BackFill Compression ", Status="Idle" , LastMessage="Succeeded"},
                new Job{ JobId="2951", JobType= "Multi-Task", Descripton="Chad Image Test", Status="Complete" , LastMessage="Succeeded"},
                new Job{ JobId="2952", JobType= "Multi-Task", Descripton="Charge Export ", Status="Complete" , LastMessage="Succeeded"},
                new Job{ JobId="2955", JobType= "Multi-Task", Descripton="10- Honor Care Payment Processing (Client) ", Status="Complete" , LastMessage="Succeeded"},
                new Job{ JobId="2955", JobType= "Multi-Task", Descripton="11- Honor Care Payment Processing (Client) ", Status="Complete" , LastMessage="Succeeded"},
                new Job{ JobId="2954", JobType= "Multi-Task", Descripton="10- Address Update ", Status="Idle" , LastMessage="Succeeded"},
                new Job{ JobId="2952", JobType= "Multi-Task", Descripton="10- BackFill Compression ", Status="Idle" , LastMessage="Succeeded"},
                new Job{ JobId="2951", JobType= "Multi-Task", Descripton="Chad Image Test", Status="Complete" , LastMessage="Succeeded"},
                new Job{ JobId="2952", JobType= "Multi-Task", Descripton="Charge Export ", Status="Complete" , LastMessage="Succeeded"},


            };
        }

    }
}
