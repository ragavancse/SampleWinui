using SampleWinui.Common;
using SampleWinui.Helpers;
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
        public RelayCommand SelectAllCommand { get; set; }
        public RelayCommand DisSelectAll { get; set; }

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
            SelectAllCommand = new RelayCommand(obj => OnClick(obj));
            DisSelectAll = new RelayCommand(obj => OnClickDisselect(obj));
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

        private void OnClick(object obj)
        {
            foreach (var item in Issues)
            {
                item.IsSelected= true;
            }


        }

        private void OnClickDisselect(object obj)
        {
            foreach (var item in Issues)
            {
                item.IsSelected = false;
            }

        }



        public List<Issue> SelectedItemsList => Issues.Where(item => item.IsSelected).ToList();

    }
}
