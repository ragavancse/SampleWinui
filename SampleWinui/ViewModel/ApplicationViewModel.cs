using SampleWinui.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWinui.ViewModel
{
    public class ApplicationViewModel
    {
        private ObservableCollection<ApplicationModel> application;

        public ObservableCollection<ApplicationModel> Application
        {
            get { return application; }
            set { application = value; }

        }


        public ApplicationViewModel()
        {
            Application = new ObservableCollection<ApplicationModel>();
            Application.Add(new ApplicationModel { Name = "Privarcy", RootFolder = @"c:\Program Files(x84)\TPI\IMAGINE\Appliance", Local = "Yes", Privary = "Yes", ExcutableName = "ImagineApplianceService.exe", Service_Name="ImagineApplianceService" });
            Application.Add(new ApplicationModel { Name = "Privarcy", RootFolder = @"c:\Program Files(x84)\TPI\IMAGINE\Appliance", Local = "Yes", Privary = "Yes", ExcutableName = "ImagineApplianceService.exe", Service_Name= "ImagineApplianceService" });
            Application.Add(new ApplicationModel { Name = "Privarcy", RootFolder = @"c:\Program Files(x84)\TPI\IMAGINE\Appliance", Local = "Yes", Privary = "Yes", ExcutableName = "ImagineApplianceService.exe", Service_Name="ImagineApplianceService" });
        }
    }
}
