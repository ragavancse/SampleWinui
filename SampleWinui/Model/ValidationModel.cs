using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SampleWinui.Model
{
    public class ValidationModel
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private ObservableCollection<string> child
            ;

        public ObservableCollection<string> Child

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
    }
}
