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
    public class ScheduleListItemsViewModel : ViewModelBase
    { 
        public ObservableCollection<ScheduleListItemsModel> WeekCollection { get; set; }

        public string DefaultFilter = "dayOnly";

        public RelayCommand Filter { get; set; }

        public RelayCommand TimeFilter { get; set; }

        private bool datePickEnable;

        public bool DatePickEnable
        {
            get { return datePickEnable; }
            set { datePickEnable = value; OnPropertyChanged("DatePickEnable"); }
        }

        private bool dayOfMonthEnable;

        public bool DayOfMonthEnable
        {
            get { return dayOfMonthEnable; }
            set { dayOfMonthEnable = value; OnPropertyChanged("DayOfMonthEnable"); }
        }


        private bool enableWeeks;

        public bool EnableWeeks
        {
            get { return enableWeeks; }
            set { enableWeeks = value; OnPropertyChanged("EnableWeeks"); }
        }


        private bool leftTimePanel;

        public bool LeftTimePanel
        {
            get { return leftTimePanel; }
            set { leftTimePanel = value; OnPropertyChanged("LeftTimePanel"); }
        }


        private bool rightTimePanel;

        public bool RightTimePanel
        {
            get { return rightTimePanel; }
            set { rightTimePanel = value; OnPropertyChanged("RightTimePanel"); }
        }

        public ScheduleListItemsViewModel()
        {
            WeekCollection = new ObservableCollection<ScheduleListItemsModel>() ;
            WeekCollection.Add(new ScheduleListItemsModel() { Day = "Monday"} );
            WeekCollection.Add(new ScheduleListItemsModel() { Day = "Tuesday" });
            WeekCollection.Add(new ScheduleListItemsModel() { Day = "Wednesday" });
            WeekCollection.Add(new ScheduleListItemsModel() { Day = "Thursday" });
            WeekCollection.Add(new ScheduleListItemsModel() { Day = "Friday" });
            WeekCollection.Add(new ScheduleListItemsModel() { Day = "Saturday" });
            WeekCollection.Add(new ScheduleListItemsModel() { Day = "Sunday" });
           
            Filter = new RelayCommand(obj => OnFilterDays(obj));
            TimeFilter = new RelayCommand(obj => OnTimeFilter(obj));
            OnFilter(DefaultFilter);
        }



        private void OnTimeFilter(object obj)
        {
            var item = obj as string;
            switch (item)
            {
                case "specificTime":
                    LeftTimePanel = true;
                    RightTimePanel = false;
                    break;
                case "autoRecurring":
                    LeftTimePanel = false;
                    RightTimePanel = true;
                    break;
            }
        }

        private void OnFilterDays(Object obj)
        {
            DefaultFilter = obj as string;
            OnFilter(DefaultFilter);
        }

        private void OnFilter(string defaultFilter)
        {
            switch (defaultFilter)
            {
                case "dayOnly":
                    DatePickEnable = true;
                    DayOfMonthEnable = false;
                    EnableWeeks = false;
                    LeftTimePanel = true;
                    break;
                case "dayOfWeek":
                    DatePickEnable = false;
                    DayOfMonthEnable = false;
                    EnableWeeks = true;
                    LeftTimePanel = true;
                    break;
                case "dayOfMonth":
                    DatePickEnable = false;
                    DayOfMonthEnable = true;
                    EnableWeeks = false;
                    LeftTimePanel = true;
                    break;
            }
        }
    }
}
