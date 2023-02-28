using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWinui.Model
{
    public class ScheduleItem
    {
        //public string Name { get; set; }
        //public List<ScheduleItem> Children { get; set; }

        //public  Image { get; set; }    
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private ObservableCollection<ScheduleItem> child
            ;

        public ObservableCollection<ScheduleItem> Child

        {
            get { return child; }
            set { child = value; }
        }

        private int key;

        public int Key
        {
            get { return key; }
            set { key = value; }
        }

        private string nameCollection;

        public string NameCollection
        {
            get { return nameCollection; }
            set { nameCollection = value; }
        }


        

    }
}
