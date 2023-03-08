using SampleWinui.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWinui.ViewModel
{
    public class ChildSchduleViewModel
    {
        private ObservableCollection<ChildScheduleModel> schduleContents;

        public ObservableCollection<ChildScheduleModel> SchduleContents
        {
            get { return schduleContents; }
            set { schduleContents = value; }
        }

        public ChildSchduleViewModel()
        {
            SchduleContents = new ObservableCollection<ChildScheduleModel>();
            SchduleContents.Add(new ChildScheduleModel {Date="One Day Only:Wed Oct21 2020",Time="02:05 PM",Enabled="Yes" });
            SchduleContents.Add(new ChildScheduleModel { Date = "One Day Only:Wed Oct21 2020", Time = "02:05 PM", Enabled = "Yes" });
            SchduleContents.Add(new ChildScheduleModel { Date = "One Day Only:Wed Oct21 2020", Time = "07:15 PM", Enabled = "No" });
            SchduleContents.Add(new ChildScheduleModel { Date = "One Day Only:Wed Oct21 2020", Time = "02:05 PM", Enabled = "Yes" });
            SchduleContents.Add(new ChildScheduleModel { Date = "One Day Only:Wed Oct21 2020", Time = "02:05 PM", Enabled = "Yes" });
            SchduleContents.Add(new ChildScheduleModel { Date = "One Day Only:Wed Oct21 2020", Time = "02:05 PM", Enabled = "Yes" });
        }
    }
}