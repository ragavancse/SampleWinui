using SampleWinui.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWinui.ViewModel
{
    public class FileViewModel
    {
        private ObservableCollection<FileModel> setupCollections;

        public ObservableCollection<FileModel> SetupCollections
        {
            get { return setupCollections; }
            set { setupCollections = value; }
        }

        private ObservableCollection<FileModel> systemUtilitiesCollections;

        public ObservableCollection<FileModel> SystemUtilitiesCollections
        {
            get { return systemUtilitiesCollections; }
            set { systemUtilitiesCollections = value; }
        }

        public FileViewModel()
        {
            SetupCollections = new ObservableCollection<FileModel>() { new FileModel() { Icon = "/Image/Icon_Instances.svg", HeaderText = "Instances", FooterText = "Lorem ipsum dolor sit amet,Consectetur adipiscing elit, sed do eiusmod tempor incididunt ut." },
           new FileModel() { Icon = "/Image/Path 1854.svg", HeaderText = "Service", FooterText = "Lorem ipsum dolor sit amet,Consectetur adipiscing elit, sed do eiusmod tempor incididunt ut." },
            new FileModel() { Icon = "/Image/Icon_PMMS.svg", HeaderText = "PMMS", FooterText = "Lorem ipsum dolor sit amet,Consectetur adipiscing elit, sed do eiusmod tempor incididunt ut." },
            new FileModel() { Icon = "/Image/Icon_E-mail.svg", HeaderText = "Email", FooterText = "Lorem ipsum dolor sit amet,Consectetur adipiscing elit, sed do eiusmod tempor incididunt ut." }};


            SystemUtilitiesCollections = new ObservableCollection<FileModel>() { new FileModel() { Icon = "/Image/Icon_Backup.svg", HeaderText = "Backup", FooterText = "Lorem ipsum dolor sit amet,Consectetur adipiscing elit, sed do eiusmod tempor incididunt ut." },
           new FileModel() { Icon = "/Image/Icon_Show Schedule.svg", HeaderText = "Show Schedule", FooterText = "Lorem ipsum dolor sit amet,Consectetur adipiscing elit, sed do eiusmod tempor incididunt ut." },
            new FileModel() { Icon = "/Image/Icon_Hamburguer.svg", HeaderText = "Show Status", FooterText = "Lorem ipsum dolor sit amet,Consectetur adipiscing elit, sed do eiusmod tempor incididunt ut." },
            new FileModel() { Icon = "/Image/Path 1854.svg", HeaderText = "Validate Modules", FooterText = "Lorem ipsum dolor sit amet,Consectetur adipiscing elit, sed do eiusmod tempor incididunt ut." },
             new FileModel() { Icon = "/Image/Icon_Instances.svg", HeaderText = "Show Objects", FooterText = "Lorem ipsum dolor sit amet,Consectetur adipiscing elit, sed do eiusmod tempor incididunt ut." },
             new FileModel() { Icon = "/Image/Icon_E-mail.svg", HeaderText = "Manage Modules", FooterText = "Lorem ipsum dolor sit amet,Consectetur adipiscing elit, sed do eiusmod tempor incididunt ut." }};
        }
    }
}
