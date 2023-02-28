using SampleWinui.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWinui.ViewModel
{
    public class MonitorViewModel
    {
        public List<Monitor> monitors=>GetMonitors().ToList();

        public List<MonitorSub> monitorsub=>GetMonitorSubs().ToList();

        public List<Monitor> GetMonitors()
        {
            return new List<Monitor>()
            {
                new Monitor{ RunningProcessId="44756",RunningActivity="4659",Started="11/04/2021 10:00:01",Type="Job",Id="7384544",Description="Downloads SAPA-Project EG",FailedTask="0/0",Status="Running Download-BAYLOR ST LUKE EMERG CTR CONROE(BSLECC)" },
                new Monitor{ RunningProcessId="44756",RunningActivity="4659",Started="11/04/2021 10:00:01",Type="Job",Id="7384544",Description="Downloads SAPA-Project EG",FailedTask="0/0",Status="Running Download-BAYLOR ST LUKE EMERG CTR CONROE(BSLECC)" },
                new Monitor{ RunningProcessId="44756",RunningActivity="4659",Started="11/04/2021 10:00:01",Type="Job",Id="7384544",Description="Downloads SAPA-Project EG",FailedTask="0/0",Status="Running Download-BAYLOR ST LUKE EMERG CTR CONROE(BSLECC)" },
                new Monitor{ RunningProcessId="44756",RunningActivity="4659",Started="11/04/2021 10:00:01",Type="Job",Id="7384544",Description="Downloads SAPA-Project EG",FailedTask="0/0",Status="Running Download-BAYLOR ST LUKE EMERG CTR CONROE(BSLECC)" },
                new Monitor{ RunningProcessId="44756",RunningActivity="4659",Started="11/04/2021 10:00:01",Type="Job",Id="7384544",Description="Downloads SAPA-Project EG",FailedTask="0/0",Status="Running Download-BAYLOR ST LUKE EMERG CTR CONROE(BSLECC)" },
                new Monitor{ RunningProcessId="44756",RunningActivity="4659",Started="11/04/2021 10:00:01",Type="Job",Id="7384544",Description="Downloads SAPA-Project EG",FailedTask="0/0",Status="Running Download-BAYLOR ST LUKE EMERG CTR CONROE(BSLECC)" },
                new Monitor{ RunningProcessId="44756",RunningActivity="4659",Started="11/04/2021 10:00:01",Type="Job",Id="7384544",Description="Downloads SAPA-Project EG",FailedTask="0/0",Status="Running Download-BAYLOR ST LUKE EMERG CTR CONROE(BSLECC)" },
                new Monitor{ RunningProcessId="44756",RunningActivity="4659",Started="11/04/2021 10:00:01",Type="Job",Id="7384544",Description="Downloads SAPA-Project EG",FailedTask="0/0",Status="Running Download-BAYLOR ST LUKE EMERG CTR CONROE(BSLECC)" },
                 new Monitor{ RunningProcessId="44756",RunningActivity="4659",Started="11/04/2021 10:00:01",Type="Job",Id="7384544",Description="Downloads SAPA-Project EG",FailedTask="0/0",Status="Running Download-BAYLOR ST LUKE EMERG CTR CONROE(BSLECC)" },
                new Monitor{ RunningProcessId="44756",RunningActivity="4659",Started="11/04/2021 10:00:01",Type="Job",Id="7384544",Description="Downloads SAPA-Project EG",FailedTask="0/0",Status="Running Download-BAYLOR ST LUKE EMERG CTR CONROE(BSLECC)" },
                new Monitor{ RunningProcessId="44756",RunningActivity="4659",Started="11/04/2021 10:00:01",Type="Job",Id="7384544",Description="Downloads SAPA-Project EG",FailedTask="0/0",Status="Running Download-BAYLOR ST LUKE EMERG CTR CONROE(BSLECC)" },
                new Monitor{ RunningProcessId="44756",RunningActivity="4659",Started="11/04/2021 10:00:01",Type="Job",Id="7384544",Description="Downloads SAPA-Project EG",FailedTask="0/0",Status="Running Download-BAYLOR ST LUKE EMERG CTR CONROE(BSLECC)" },
                new Monitor{ RunningProcessId="44756",RunningActivity="4659",Started="11/04/2021 10:00:01",Type="Job",Id="7384544",Description="Downloads SAPA-Project EG",FailedTask="0/0",Status="Running Download-BAYLOR ST LUKE EMERG CTR CONROE(BSLECC)" },
                new Monitor{ RunningProcessId="44756",RunningActivity="4659",Started="11/04/2021 10:00:01",Type="Job",Id="7384544",Description="Downloads SAPA-Project EG",FailedTask="0/0",Status="Running Download-BAYLOR ST LUKE EMERG CTR CONROE(BSLECC)" },
                new Monitor{ RunningProcessId="44756",RunningActivity="4659",Started="11/04/2021 10:00:01",Type="Job",Id="7384544",Description="Downloads SAPA-Project EG",FailedTask="0/0",Status="Running Download-BAYLOR ST LUKE EMERG CTR CONROE(BSLECC)" },
                new Monitor{ RunningProcessId="44756",RunningActivity="4659",Started="11/04/2021 10:00:01",Type="Job",Id="7384544",Description="Downloads SAPA-Project EG",FailedTask="0/0",Status="Running Download-BAYLOR ST LUKE EMERG CTR CONROE(BSLECC)" },
                 new Monitor{ RunningProcessId="44756",RunningActivity="4659",Started="11/04/2021 10:00:01",Type="Job",Id="7384544",Description="Downloads SAPA-Project EG",FailedTask="0/0",Status="Running Download-BAYLOR ST LUKE EMERG CTR CONROE(BSLECC)" },
                new Monitor{ RunningProcessId="44756",RunningActivity="4659",Started="11/04/2021 10:00:01",Type="Job",Id="7384544",Description="Downloads SAPA-Project EG",FailedTask="0/0",Status="Running Download-BAYLOR ST LUKE EMERG CTR CONROE(BSLECC)" },
                new Monitor{ RunningProcessId="44756",RunningActivity="4659",Started="11/04/2021 10:00:01",Type="Job",Id="7384544",Description="Downloads SAPA-Project EG",FailedTask="0/0",Status="Running Download-BAYLOR ST LUKE EMERG CTR CONROE(BSLECC)" },
                new Monitor{ RunningProcessId="44756",RunningActivity="4659",Started="11/04/2021 10:00:01",Type="Job",Id="7384544",Description="Downloads SAPA-Project EG",FailedTask="0/0",Status="Running Download-BAYLOR ST LUKE EMERG CTR CONROE(BSLECC)" },
                new Monitor{ RunningProcessId="44756",RunningActivity="4659",Started="11/04/2021 10:00:01",Type="Job",Id="7384544",Description="Downloads SAPA-Project EG",FailedTask="0/0",Status="Running Download-BAYLOR ST LUKE EMERG CTR CONROE(BSLECC)" },
                new Monitor{ RunningProcessId="44756",RunningActivity="4659",Started="11/04/2021 10:00:01",Type="Job",Id="7384544",Description="Downloads SAPA-Project EG",FailedTask="0/0",Status="Running Download-BAYLOR ST LUKE EMERG CTR CONROE(BSLECC)" },
                new Monitor{ RunningProcessId="44756",RunningActivity="4659",Started="11/04/2021 10:00:01",Type="Job",Id="7384544",Description="Downloads SAPA-Project EG",FailedTask="0/0",Status="Running Download-BAYLOR ST LUKE EMERG CTR CONROE(BSLECC)" },
                new Monitor{ RunningProcessId="44756",RunningActivity="4659",Started="11/04/2021 10:00:01",Type="Job",Id="7384544",Description="Downloads SAPA-Project EG",FailedTask="0/0",Status="Running Download-BAYLOR ST LUKE EMERG CTR CONROE(BSLECC)" },
            };
        }

        public List<MonitorSub> GetMonitorSubs()
        {
            return new List<MonitorSub>
            {
               new MonitorSub{Groups="44756",Started="01/01/2021",Enabled="True",TaskId="4659",TaskDescription="Downloads SAPA-Project EG",Status="Running Download-BAYLOR ST LUKE EMERG CTR CONROE(BSLECC)",TaskModule="1" },
                new MonitorSub{Groups="44756",Started="01/01/2021",Enabled="True",TaskId="4659",TaskDescription="Downloads SAPA-Project EG",Status="Running Download-BAYLOR ST LUKE EMERG CTR CONROE(BSLECC)",TaskModule="2" },
                new MonitorSub{Groups="44756",Started="01/01/2021",Enabled="True",TaskId="4659",TaskDescription="Downloads SAPA-Project EG",Status="Running Download-BAYLOR ST LUKE EMERG CTR CONROE(BSLECC)",TaskModule="3" },
                 new MonitorSub{Groups="44756",Started="01/01/2021",Enabled="True",TaskId="4659",TaskDescription="Downloads SAPA-Project EG",Status="Running Download-BAYLOR ST LUKE EMERG CTR CONROE(BSLECC)",TaskModule="1" },
                new MonitorSub{Groups="44756",Started="01/01/2021",Enabled="True",TaskId="4659",TaskDescription="Downloads SAPA-Project EG",Status="Running Download-BAYLOR ST LUKE EMERG CTR CONROE(BSLECC)",TaskModule="2" },
                new MonitorSub{Groups="44756",Started="01/01/2021",Enabled="True",TaskId="4659",TaskDescription="Downloads SAPA-Project EG",Status="Running Download-BAYLOR ST LUKE EMERG CTR CONROE(BSLECC)",TaskModule="3" },
                 new MonitorSub{Groups="44756",Started="01/01/2021",Enabled="True",TaskId="4659",TaskDescription="Downloads SAPA-Project EG",Status="Running Download-BAYLOR ST LUKE EMERG CTR CONROE(BSLECC)",TaskModule="1" },
                new MonitorSub{Groups="44756",Started="01/01/2021",Enabled="True",TaskId="4659",TaskDescription="Downloads SAPA-Project EG",Status="Running Download-BAYLOR ST LUKE EMERG CTR CONROE(BSLECC)",TaskModule="2" },
                new MonitorSub{Groups="44756",Started="01/01/2021",Enabled="True",TaskId="4659",TaskDescription="Downloads SAPA-Project EG",Status="Running Download-BAYLOR ST LUKE EMERG CTR CONROE(BSLECC)",TaskModule="3" },
                 new MonitorSub{Groups="44756",Started="01/01/2021",Enabled="True",TaskId="4659",TaskDescription="Downloads SAPA-Project EG",Status="Running Download-BAYLOR ST LUKE EMERG CTR CONROE(BSLECC)",TaskModule="1" },
                new MonitorSub{Groups="44756",Started="01/01/2021",Enabled="True",TaskId="4659",TaskDescription="Downloads SAPA-Project EG",Status="Running Download-BAYLOR ST LUKE EMERG CTR CONROE(BSLECC)",TaskModule="2" },
                new MonitorSub{Groups="44756",Started="01/01/2021",Enabled="True",TaskId="4659",TaskDescription="Downloads SAPA-Project EG",Status="Running Download-BAYLOR ST LUKE EMERG CTR CONROE(BSLECC)",TaskModule="3" }
            };
        }

    }
}
