using SampleWinui.Common;
using SampleWinui.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWinui.ViewModel
{
    public class IssuesViewModel : ViewModelBase
    {
        private ObservableCollection<Issue> issues;
        public ObservableCollection<Issue> Issues
        {
            get { return issues; }
            set
            {
                issues = value;
                OnPropertyChanged(nameof(Issues));
            }
        }

        public IssuesViewModel()
        {
            Issues = new ObservableCollection<Issue>()
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
