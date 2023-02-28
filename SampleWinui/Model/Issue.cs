using SampleWinui.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWinui.Model
{
    public class Issue : ViewModelBase
    {
      
        public string JobName { get; set; }
        public string TaskName { get; set; }
        public string ErrorDate { get; set; }
        public string ErrorMessage { get; set; }
        public string Status { get; set; }
        public string WorkedOn { get; set; }
        public string WorkedBy { get; set; }

        private bool isSelected;
        public bool IsSelected
        {
            get =>  isSelected;
            set
               {
                isSelected = value;
                OnPropertyChanged();
            }
        }
    }
}
