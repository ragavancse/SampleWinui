using Microsoft.UI.Xaml.Controls;
using SampleWinui.Common;
using SampleWinui.Helpers;
using SampleWinui.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWinui.ViewModel
{
    public class JobsViewModel : ViewModelBase
    {
        public JobsViewModel()
        {
            Jobs = JobsUnFiltered = GetJobs();
        }

        private ObservableCollection<Job> _jobs;

        public ObservableCollection<Job> Jobs
        {
            get { return _jobs; }
            set
            {
                _jobs = value;
                OnPropertyChanged(nameof(Jobs));
            }
        }

        public ObservableCollection<string> Logs { get; set; }


        public void SetLogs()
        {
            Logs = new ObservableCollection<string>(){
                new string ("01/13/2015 01:59:01 678 PM: configuration saved by [DTear]"),
                 new string ("01/13/2015 01:59:01 678 PM: configuration saved by [DTear]"),
                new string ("01/13/2015 01:59:01 678 PM: configuration saved by [DTear]"),
                 new string ("01/13/2015 01:59:01 678 PM: configuration saved by [DTear]"),
                 new string ("01/13/2015 01:59:01 678 PM: configuration saved by [DTear]"),
                 new string ("01/13/2015 01:59:01 678 PM: configuration saved by [DTear]"),
                 new string ("01/13/2015 01:59:01 678 PM: configuration saved by [DTear]") };

            OnPropertyChanged(nameof(Logs));


        }

        private RelayCommand clearLogsCommand;

        public RelayCommand ClearLogsCommand
        {
            get { return clearLogsCommand; }
            set { clearLogsCommand = value; }
        }


        public string SearchText
        {
            get => searchText;
            set
            {
                searchText = value;
                Jobs = new ObservableCollection<Job>(GetJobs().Where(a => a.JobId.Contains(value) || a.Descripton.ToLower().Contains(searchText.ToLower())));
            }
        }
        private int _AllJobsCount;

        public int AllJobsCount
        {
            get { return Jobs.Count; }
            set
            {
                _AllJobsCount = value;
                OnPropertyChanged(nameof(AllJobsCount));
            }
        }

        private int _RunningJobsCount;

        public int RunningJobsCount
        {
            get { return Jobs.Where(a => a.Status == "Complete").Count(); }
            set
            {
                _RunningJobsCount = value;
                OnPropertyChanged(nameof(RunningJobsCount));
            }
        }

        private int _FailedJobsCount;

        public int FailedJobsCount
        {
            get { return Jobs.Where(a => a.Status == "Failed").Count(); }
            set
            {
                _FailedJobsCount = value;
                OnPropertyChanged(nameof(FailedJobsCount));
            }
        }


        public object SelectedItem
        {
            get => selectedItem;
            set
            {
                selectedItem = value;
                if (value is NavigationViewItem item)
                {
                    switch (item.Tag.ToString())
                    {
                        case "All Jobs":
                            Jobs = GetJobs();
                            break;
                        case "Running Jobs":
                            Jobs = new ObservableCollection<Job>(GetJobs().Where(a => a.Status == "Complete"));
                            break;
                        case "Failed Jobs":
                            Jobs = new ObservableCollection<Job>(GetJobs().Where(a => a.Status == "Failed"));
                            break;
                    }

                }
            }
        }

        private ObservableCollection<Job> _jobsUnFiltered;
        private object selectedItem;
        private string searchText;

        public ObservableCollection<Job> JobsUnFiltered
        {
            get { return _jobsUnFiltered; }
            set { _jobsUnFiltered = value; }
        }

        public ObservableCollection<Job> GetJobs()
        {
            return new ObservableCollection<Job>
            {
                new Job{ JobId="2955", JobType= "Multi-Task", Descripton="10- Honor Care Payment Processing (Client) ", Status="Complete" , LastMessage="Succeeded"},
                new Job{ JobId="2955", JobType= "Multi-Task", Descripton="11- Honor Care Payment Processing (Client) ", Status="Failed" , LastMessage="Succeeded"},
                new Job{ JobId="2954", JobType= "Multi-Task", Descripton="10- Address Update ", Status="Idle" , LastMessage="Succeeded"},
                new Job{ JobId="2952", JobType= "Multi-Task", Descripton="10- BackFill Compression ", Status="Idle" , LastMessage="Failed"},
                new Job{ JobId="2951", JobType= "Multi-Task", Descripton="Chad Image Test", Status="Complete" , LastMessage="Succeeded"},
                new Job{ JobId="2952", JobType= "Multi-Task", Descripton="Charge Export ", Status="Complete" , LastMessage="Succeeded"},
                 new Job{ JobId="2955", JobType= "Multi-Task", Descripton="10- Honor Care Payment Processing (Client) ", Status="Complete" , LastMessage="Succeeded"},
                new Job{ JobId="2955", JobType= "Multi-Task", Descripton="11- Honor Care Payment Processing (Client) ", Status="Failed" , LastMessage="Succeeded"},
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
                new Job{ JobId="2952", JobType= "Multi-Task", Descripton="10- BackFill Compression ", Status="Idle" , LastMessage="Failed"},
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
