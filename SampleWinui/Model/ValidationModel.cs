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

        private ObservableCollection<ValidationModel> children;
            

        public ObservableCollection<ValidationModel> Children

        {
            get { return children; }
            set { children = value; }
        }

        private int key;

        public int Key
        {
            get { return key; }
            set { key = value; }
        }
    }
}
