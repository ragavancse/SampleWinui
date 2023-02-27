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
    public class JobsViewModel : BaseVM
    {

        public JobsViewModel()
        {
            FirstPageCommand = new RelayCommand(RunFirstPageCommand);
            PrevPageCommand = new RelayCommand(RunPrevPageCommand);
            NextPageCommand = new RelayCommand(RunNextPageCommand);
            LastPageCommand = new RelayCommand(RunLastPageCommand);
            PageSizeUpdateCommand = new RelayCommand(RunPageSizeUpdateCommand);
            Jobs = JobsUnFiltered = GetJobs();
            FirstPageCommand?.Execute(null);
        }

        private ObservableCollection<Job> _jobs;

        public ObservableCollection<Job> Jobs
        {
            get { return _jobs; }
            set { _jobs = value;
                RaisePropertyChanged(nameof(Jobs));
            }
        }

        private ObservableCollection<Job> _jobsUnFiltered;

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

        private void RunFirstPageCommand()
        {
            // Display the first page
            if (CurrentPageIndex != 0)
                CurrentPageIndex = 0;
            TotalItems = JobsUnFiltered.Count();

            UpdateTotalPageCount();
        }

        private void RunPrevPageCommand()
        {
            // Display previous page
            if (CurrentPageIndex > 0)
                CurrentPageIndex--;

            ShowCurrentPageIndex();
        }

        private void RunNextPageCommand()
        {
            // Display next page
            if (CurrentPageIndex < TotalPage - 1)
                CurrentPageIndex++;

            ShowCurrentPageIndex();
        }

        private void RunLastPageCommand()
        {
            // Display the last page
            if (CurrentPageIndex != TotalPage - 1)
                CurrentPageIndex = TotalPage - 1;

            ShowCurrentPageIndex();
        }

        private void RunPageSizeUpdateCommand()
        {
            if (JobsUnFiltered.Count() > 0)
                UpdateTotalPageCount();
        }

        private void ShowCurrentPageIndex()
        {
            if (JobsUnFiltered.Count() > 0)
            {
                Jobs = new ObservableCollection<Job>(JobsUnFiltered.Skip(CurrentPageIndex * ItemPerPage).Take(ItemPerPage));
                CurrentPage = CurrentPageIndex + 1;
                CurrentPageStart = (CurrentPageIndex * ItemPerPage) + 1;
                CurrentPageEnd = (CurrentPageIndex + 1) * ItemPerPage > TotalItems ? TotalItems : (CurrentPageIndex + 1) * ItemPerPage;
            }
        }

        public void UpdateTotalPageCount()
        {
            CurrentPageIndex = 0;
            TotalPage = JobsUnFiltered.Count() % ItemPerPage == 0 ? JobsUnFiltered.Count() / ItemPerPage : JobsUnFiltered.Count() / ItemPerPage + 1;
            ShowCurrentPageIndex();

            //TotalPageCountNG = !FromObj.IsNullOrEmpty() ? (FromObj.Count % ItemPerPageNG == 0 ? FromObj.Count / ItemPerPageNG : FromObj.Count / ItemPerPageNG + 1) : 0;
            //TotalPageNG = TotalPageCountNG.ToString();
        }

    }
}
