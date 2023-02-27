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
                            new ScheduleItem() { Key = 1, Name = "MIPS", Items = new ObservableCollection<string>() { "Episode:60", "Episode:59", "Episode:58", "Episode:57", "Episode:56", "Episode:55" } },
                            new ScheduleItem() { Key = 1, Name = "Billing Engine", Items = new ObservableCollection<string>() { "Episode:60", "Episode:59", "Episode:58", "Episode:57", "Episode:56", "Episode:55" } },
                            new ScheduleItem() { Key = 1, Name = "Interpretation Location Update", Items = new ObservableCollection<string>() { "Episode:60", "Episode:59", "Episode:58", "Episode:57", "Episode:56", "Episode:55" } },
                            new ScheduleItem() { Key = 1, Name = "eManagementassociates - Collections - Send to EMA", Items = new ObservableCollection<string>() { "Episode:60", "Episode:59", "Episode:58", "Episode:57", "Episode:56", "Episode:55" } },
                            new ScheduleItem() { Key = 1, Name = "eManagementassociates - Collections - Pick Up From EMA", Items = new ObservableCollection<string>() { "Episode:60", "Episode:59", "Episode:58", "Episode:57", "Episode:56", "Episode:55" } },
                            new ScheduleItem() { Key = 1, Name = "DMA - ePAY", Items = new ObservableCollection<string>() { "Episode:60", "Episode:59", "Episode:58", "Episode:57", "Episode:56", "Episode:55" } },
                            new ScheduleItem() { Key = 1, Name = "Order Verification", Items = new ObservableCollection<string>() { "Episode:60", "Episode:59", "Episode:58", "Episode:57", "Episode:56", "Episode:55" } },
                            new ScheduleItem() { Key = 1, Name = "BankingQ - PMP", Items = new ObservableCollection<string>() { "Episode:60", "Episode:59", "Episode:58", "Episode:57", "Episode:56", "Episode:55" } },
                            new ScheduleItem() { Key = 1, Name = "Additional Remit Pull", Items = new ObservableCollection<string>() { "Episode:60", "Episode:59", "Episode:58", "Episode:57", "Episode:56", "Episode:55" } },


                        };
            foreach (var item in Items)
            {
                TreeViewNode node = new TreeViewNode { Content = item.Name };
                //AddNode(node);
                ScheduleItem schedule=new ScheduleItem();

                
                schedule.NameCollection = node.Content.ToString();




        foreach (var item1 in item.Items)
                {
                    TreeViewNode node1 = new TreeViewNode { Content = item1 };
                    node.Children.Add(node1);
                }
            }
        }

        //public void AddNode(TreeViewNode treeNode)


        //{

        //    Add(treeNode);
        //}




        //public ObservableCollection<ScheduleItem> Items { get; set; }= new ObservableCollection<ScheduleItem>() { new Items() { N} };
        //Items = new ObservableCollection<ScheduleItem>()
        //{
        //    new ScheduleItem()  {Name="Item 1"},
        //    new ScheduleItem()  {Name="Item 2"},

        //};

    }
    
}











