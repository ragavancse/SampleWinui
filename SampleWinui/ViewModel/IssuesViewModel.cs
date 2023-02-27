using SampleWinui.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWinui.ViewModel
{
    public class IssuesViewModel 
    {
        public List<Issue> Issues => GetIssues().ToList();
        public List<Issue> GetIssues()
        {
            return new List<Issue>()
            {
                new Issue{JobName="Job Name",TaskName="Task Name",ErrorDate="1/1/2022",ErrorMessage="Error Message",Status="Completed",WorkedOn="Worked On",WorkedBy="John Doe"},
                new Issue{JobName="Job Name",TaskName="Task Name",ErrorDate="1/1/2022",ErrorMessage="Error Message",Status="Idle",WorkedOn="Worked On",WorkedBy="John Doe"},
                new Issue{JobName="Job Name",TaskName="Task Name",ErrorDate="1/1/2022",ErrorMessage="Error Message",Status="Running",WorkedOn="Worked On",WorkedBy="John Doe"},
                  new Issue{JobName="Job Name",TaskName="Task Name",ErrorDate="1/1/2022",ErrorMessage="Error Message",Status="Completed",WorkedOn="Worked On",WorkedBy="John Doe"},
                new Issue{JobName="Job Name",TaskName="Task Name",ErrorDate="1/1/2022",ErrorMessage="Error Message",Status="Idle",WorkedOn="Worked On",WorkedBy="John Doe"},
                new Issue{JobName="Job Name",TaskName="Task Name",ErrorDate="1/1/2022",ErrorMessage="Error Message",Status="Running",WorkedOn="Worked On",WorkedBy="John Doe"},
                  new Issue{JobName="Job Name",TaskName="Task Name",ErrorDate="1/1/2022",ErrorMessage="Error Message",Status="Completed",WorkedOn="Worked On",WorkedBy="John Doe"},
                new Issue{JobName="Job Name",TaskName="Task Name",ErrorDate="1/1/2022",ErrorMessage="Error Message",Status="Idle",WorkedOn="Worked On",WorkedBy="John Doe"},
                new Issue{JobName="Job Name",TaskName="Task Name",ErrorDate="1/1/2022",ErrorMessage="Error Message",Status="Running",WorkedOn="Worked On",WorkedBy="John Doe"},
                  new Issue{JobName="Job Name",TaskName="Task Name",ErrorDate="1/1/2022",ErrorMessage="Error Message",Status="Completed",WorkedOn="Worked On",WorkedBy="John Doe"},
                new Issue{JobName="Job Name",TaskName="Task Name",ErrorDate="1/1/2022",ErrorMessage="Error Message",Status="Idle",WorkedOn="Worked On",WorkedBy="John Doe"},
                new Issue{JobName="Job Name",TaskName="Task Name",ErrorDate="1/1/2022",ErrorMessage="Error Message",Status="Running",WorkedOn="Worked On",WorkedBy="John Doe"},
                new Issue{JobName="Job Name",TaskName="Task Name",ErrorDate="1/1/2022",ErrorMessage="Error Message",Status="Completed",WorkedOn="Worked On",WorkedBy="John Doe"},
                new Issue{JobName="Job Name",TaskName="Task Name",ErrorDate="1/1/2022",ErrorMessage="Error Message",Status="Idle",WorkedOn="Worked On",WorkedBy="John Doe"},
                new Issue{JobName="Job Name",TaskName="Task Name",ErrorDate="1/1/2022",ErrorMessage="Error Message",Status="Running",WorkedOn="Worked On",WorkedBy="John Doe"},
                new Issue{JobName="Job Name",TaskName="Task Name",ErrorDate="1/1/2022",ErrorMessage="Error Message",Status="Completed",WorkedOn="Worked On",WorkedBy="John Doe"},
                new Issue{JobName="Job Name",TaskName="Task Name",ErrorDate="1/1/2022",ErrorMessage="Error Message",Status="Idle",WorkedOn="Worked On",WorkedBy="John Doe"},
                new Issue{JobName="Job Name",TaskName="Task Name",ErrorDate="1/1/2022",ErrorMessage="Error Message",Status="Running",WorkedOn="Worked On",WorkedBy="John Doe"},
                new Issue{JobName="Job Name",TaskName="Task Name",ErrorDate="1/1/2022",ErrorMessage="Error Message",Status="Completed",WorkedOn="Worked On",WorkedBy="John Doe"},
                new Issue{JobName="Job Name",TaskName="Task Name",ErrorDate="1/1/2022",ErrorMessage="Error Message",Status="Idle",WorkedOn="Worked On",WorkedBy="John Doe"},
                new Issue{JobName="Job Name",TaskName="Task Name",ErrorDate="1/1/2022",ErrorMessage="Error Message",Status="Completed",WorkedOn="Worked On",WorkedBy="John Doe"},
                new Issue{JobName="Job Name",TaskName="Task Name",ErrorDate="1/1/2022",ErrorMessage="Error Message",Status="Idle",WorkedOn="Worked On",WorkedBy="John Doe"},
                new Issue{JobName="Job Name",TaskName="Task Name",ErrorDate="1/1/2022",ErrorMessage="Error Message",Status="Completed",WorkedOn="Worked On",WorkedBy="John Doe"},
                new Issue{JobName="Job Name",TaskName="Task Name",ErrorDate="1/1/2022",ErrorMessage="Error Message",Status="Idle",WorkedOn="Worked On",WorkedBy="John Doe"},
                new Issue{JobName="Job Name",TaskName="Task Name",ErrorDate="1/1/2022",ErrorMessage="Error Message",Status="Running",WorkedOn="Worked On",WorkedBy="John Doe"},
                new Issue{JobName="Job Name",TaskName="Task Name",ErrorDate="1/1/2022",ErrorMessage="Error Message",Status="Running",WorkedOn="Worked On",WorkedBy="John Doe"},
                new Issue{JobName="Job Name",TaskName="Task Name",ErrorDate="1/1/2022",ErrorMessage="Error Message",Status="Running",WorkedOn="Worked On",WorkedBy="John Doe"},
            };
        }

        public List<Issue> SelectedItemsList => Issues.Where(item => item.IsSelected).ToList();

    }
}
