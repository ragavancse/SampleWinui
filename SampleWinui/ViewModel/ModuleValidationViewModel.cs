using SampleWinui.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWinui.ViewModel
{
    public class ModuleValidationViewModel
    {
        public ObservableCollection<ScheduleItem> Items { get; set; }
        public ModuleValidationViewModel() 
        {
            Items = new ObservableCollection<ScheduleItem>()
                        {
                            new ScheduleItem() { Key = 1, Name = "Task Modules", Child = new ObservableCollection<string>() { "Episode:60", "Episode:59", "Episode:58", "Episode:57", "Episode:56", "Episode:55" } },
                            new ScheduleItem() { Key = 1, Name = "Interface Processing", Child = new ObservableCollection<string>() { "Episode:60", "Episode:59", "Episode:58", "Episode:57", "Episode:56", "Episode:55" } },
                            new ScheduleItem() { Key = 1, Name = "Advanced Zip", Child = new ObservableCollection<string>() { "Episode:60", "Episode:59", "Episode:58", "Episode:57", "Episode:56", "Episode:55" } },
                            new ScheduleItem() { Key = 1, Name = "Appliance Maintaince", Child = new ObservableCollection<string>() { "Episode:60", "Episode:59", "Episode:58", "Episode:57", "Episode:56", "Episode:55" } },
                            new ScheduleItem() { Key = 1, Name = "Auto.Faxing", Child = new ObservableCollection<string>() { "Episode:60", "Episode:59", "Episode:58", "Episode:57", "Episode:56", "Episode:55" } },
                            new ScheduleItem() { Key = 1, Name = "Claim Status", Child = new ObservableCollection<string>() { "Episode:60", "Episode:59", "Episode:58", "Episode:57", "Episode:56", "Episode:55" } },
                            new ScheduleItem() { Key = 1, Name = "Collection Write Off", Child = new ObservableCollection<string>() { "Episode:60", "Episode:59", "Episode:58", "Episode:57", "Episode:56", "Episode:55" } },
                            new ScheduleItem() { Key = 1, Name = "Data Export", Child = new ObservableCollection<string>() { "Episode:60", "Episode:59", "Episode:58", "Episode:57", "Episode:56", "Episode:55" } },
                            new ScheduleItem() { Key = 1, Name = "Data Media", Child = new ObservableCollection<string>() { "Episode:60", "Episode:59", "Episode:58", "Episode:57", "Episode:56", "Episode:55" } },
                            new ScheduleItem() { Key = 1, Name = "Download ", Child = new ObservableCollection<string>() { "Episode:60", "Episode:59", "Episode:58", "Episode:57", "Episode:56", "Episode:55" } },
                            new ScheduleItem() { Key = 1, Name = "Electronics Claims", Child = new ObservableCollection<string>() { "Episode:60", "Episode:59", "Episode:58", "Episode:57", "Episode:56", "Episode:55" } },
                            new ScheduleItem() { Key = 1, Name = "Electroni Claim Generation", Child = new ObservableCollection<string>() { "Episode:60", "Episode:59", "Episode:58", "Episode:57", "Episode:56", "Episode:55" } },
                            new ScheduleItem() { Key = 1, Name = "Electroni Remittance", Child = new ObservableCollection<string>() { "Episode:60", "Episode:59", "Episode:58", "Episode:57", "Episode:56", "Episode:55" } },
                            new ScheduleItem() { Key = 1, Name = "Eligibility", Child = new ObservableCollection<string>() { "Episode:60", "Episode:59", "Episode:58", "Episode:57", "Episode:56", "Episode:55" } },
                            new ScheduleItem() { Key = 1, Name = "Email", Child = new ObservableCollection<string>() { "Episode:60", "Episode:59", "Episode:58", "Episode:57", "Episode:56", "Episode:55" } },
                             new ScheduleItem() { Key = 1, Name = "File Transfer", Child = new ObservableCollection<string>() { "Episode:60", "Episode:59", "Episode:58", "Episode:57", "Episode:56", "Episode:55" } },
                              new ScheduleItem() { Key = 1, Name = "GlobalSync", Child = new ObservableCollection<string>() { "Episode:60", "Episode:59", "Episode:58", "Episode:57", "Episode:56", "Episode:55" } },
                               new ScheduleItem() { Key = 1, Name = "Group Appeal", Child = new ObservableCollection<string>() { "Episode:60", "Episode:59", "Episode:58", "Episode:57", "Episode:56", "Episode:55" } },
                                new ScheduleItem() { Key = 1, Name = "Image Import", Child = new ObservableCollection<string>() { "Episode:60", "Episode:59", "Episode:58", "Episode:57", "Episode:56", "Episode:55" } },
                                 new ScheduleItem() { Key = 1, Name = "Image Processing", Child = new ObservableCollection<string>() { "Episode:60", "Episode:59", "Episode:58", "Episode:57", "Episode:56", "Episode:55" } },
                                  new ScheduleItem() { Key = 1, Name = "Insurance Building", Child = new ObservableCollection<string>() { "Episode:60", "Episode:59", "Episode:58", "Episode:57", "Episode:56", "Episode:55" } },


            };

        }

    }
}
