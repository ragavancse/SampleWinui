using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using SampleWinui.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Spi;
using Windows.System;

namespace SampleWinui.ViewModel
{
    public class ObjectsViewModel
    {
        //public ObservableCollection<ScheduleItem>{get;}
        public ObservableCollection<ScheduleItem> Items { get; set; }
        public ObjectsViewModel()
        {

            Items = new ObservableCollection<ScheduleItem>()
            {
                            new ScheduleItem() { Key = 1, Name = "ScheduleItem ['\'MIPS'\']", Child = new ObservableCollection<ScheduleItem>() { new ScheduleItem { Name = "Episode:60" }, new ScheduleItem { Name ="Episode:59"}, new ScheduleItem { Name ="Episode:58", } } },
                            
                           new ScheduleItem() { Key = 2, Name = "ScheduleItem ['\'Interpretation Location Update'\']",Child = new ObservableCollection<ScheduleItem>() { new ScheduleItem { Name = "Episode:60" }, new ScheduleItem { Name ="Episode:59"}, new ScheduleItem { Name ="Episode:58", } } },
                            new ScheduleItem() { Key =3, Name = "ScheduleItem ['\'eManagementassociates - Collections - Send to EMA'\']",Child = new ObservableCollection<ScheduleItem>() { new ScheduleItem { Name = "Episode:60" }, new ScheduleItem { Name ="Episode:59"}, new ScheduleItem { Name ="Episode:58", } } },
                            new ScheduleItem() { Key =4, Name = "ScheduleItem ['\'eManagementassociates - Collections - Pick Up From EMA'\']",Child = new ObservableCollection<ScheduleItem>() { new ScheduleItem { Name = "Episode:60" }, new ScheduleItem { Name ="Episode:59"}, new ScheduleItem { Name ="Episode:58", } } },
                            new ScheduleItem() { Key = 5, Name = "ScheduleItem ['\'DMA - ePAY'\']",Child = new ObservableCollection<ScheduleItem>() { new ScheduleItem { Name = "Episode:60" }, new ScheduleItem { Name ="Episode:59"}, new ScheduleItem { Name ="Episode:58", } } },
                            new ScheduleItem() { Key = 6, Name = "ScheduleItem ['\'Order Verification'\']", Child = new ObservableCollection<ScheduleItem>() { new ScheduleItem { Name = "Episode:60" }, new ScheduleItem { Name ="Episode:59"}, new ScheduleItem { Name ="Episode:58", } } },
                            new ScheduleItem() { Key = 7, Name = "ScheduleItem ['\'BankingQ - PMP'\']", Child = new ObservableCollection<ScheduleItem>() { new ScheduleItem { Name = "Episode:60" }, new ScheduleItem { Name ="Episode:59"}, new ScheduleItem { Name ="Episode:58", } } },
                            new ScheduleItem() { Key = 8, Name = "ScheduleItem ['\'Additional Remit Pull'\']", Child = new ObservableCollection<ScheduleItem>() { new ScheduleItem { Name = "Episode:60" }, new ScheduleItem { Name ="Episode:59"}, new ScheduleItem { Name ="Episode:58", } } },
                            new ScheduleItem() { Key = 9, Name = "ScheduleItem ['\'Process Source Files'\']", Child = new ObservableCollection<ScheduleItem>() { new ScheduleItem { Name = "Episode:60" }, new ScheduleItem { Name ="Episode:59"}, new ScheduleItem { Name ="Episode:58", } } },
                            new ScheduleItem() { Key = 10, Name = "ScheduleItem ['\'Reporting Build'\']",Child = new ObservableCollection<ScheduleItem>() { new ScheduleItem { Name = "Episode:60" }, new ScheduleItem { Name ="Episode:59"}, new ScheduleItem { Name ="Episode:58", } } },
                            new ScheduleItem() { Key = 11, Name = "ScheduleItem ['\'Auto Post to Fast review'\']",Child = new ObservableCollection<ScheduleItem>() { new ScheduleItem { Name = "Episode:60" }, new ScheduleItem { Name ="Episode:59"}, new ScheduleItem { Name ="Episode:58", } } },
                            new ScheduleItem() { Key = 12, Name = "ScheduleItem ['\'Coding - 3M Extract'\']", Child = new ObservableCollection<ScheduleItem>() { new ScheduleItem { Name = "Episode:60" }, new ScheduleItem { Name ="Episode:59"}, new ScheduleItem { Name ="Episode:58", } } },
                            new ScheduleItem() { Key = 13, Name = "ScheduleItem ['\'BankingQ - qPost'\']", Child = new ObservableCollection<ScheduleItem>() { new ScheduleItem { Name = "Episode:60" }, new ScheduleItem { Name ="Episode:59"}, new ScheduleItem { Name ="Episode:58", } } },
                            new ScheduleItem() { Key = 14, Name = "ScheduleItem ['\'Coding - 3M Download'\']", Child = new ObservableCollection<ScheduleItem>() { new ScheduleItem { Name = "Episode:60" }, new ScheduleItem { Name ="Episode:59"}, new ScheduleItem { Name ="Episode:58", } } },

            };

        }
    }








}














