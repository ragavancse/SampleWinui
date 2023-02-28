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
        public ObservableCollection<ValidationModel> Items { get; set; }
        public ModuleValidationViewModel()
        {
            Items = new ObservableCollection<ValidationModel>()
                        {
                            new ValidationModel() { Key = 1, Name = "Task Modules", Children = new ObservableCollection<ValidationModel>() { new ValidationModel { Name = "Episode:60" }, new ValidationModel { Name ="Episode:59"}, new ValidationModel { Name ="Episode:58", } } },
                             new ValidationModel() { Key = 2, Name = "Interfacing Processing", Children = new ObservableCollection<ValidationModel>() { new ValidationModel { Name = "Episode:60" }, new ValidationModel { Name ="Episode:59"}, new ValidationModel { Name ="Episode:58", } } },
                              new ValidationModel() { Key = 3, Name = "Advanced Zip", Children = new ObservableCollection<ValidationModel>() { new ValidationModel { Name = "Episode:60" }, new ValidationModel { Name ="Episode:59"}, new ValidationModel { Name ="Episode:58", } } },
                               new ValidationModel() { Key = 4, Name = "Appliance Maintaince", Children = new ObservableCollection<ValidationModel>() { new ValidationModel { Name = "Episode:60" }, new ValidationModel { Name ="Episode:59"}, new ValidationModel { Name ="Episode:58", } } },
                                new ValidationModel() { Key = 5, Name = "Auto.Faxing", Children = new ObservableCollection<ValidationModel>() { new ValidationModel { Name = "Episode:60" }, new ValidationModel { Name ="Episode:59"}, new ValidationModel { Name ="Episode:58", } } },
                                 new ValidationModel() { Key = 6, Name = "Claim Status", Children = new ObservableCollection<ValidationModel>() { new ValidationModel { Name = "Episode:60" }, new ValidationModel { Name ="Episode:59"}, new ValidationModel { Name ="Episode:58", } } },
                                  new ValidationModel() { Key = 7, Name = "Collection Write Off", Children = new ObservableCollection<ValidationModel>() { new ValidationModel { Name = "Episode:60" }, new ValidationModel { Name ="Episode:59"}, new ValidationModel { Name ="Episode:58", } } },
                                   new ValidationModel() { Key = 8, Name = "Data Export", Children = new ObservableCollection<ValidationModel>() { new ValidationModel { Name = "Episode:60" }, new ValidationModel { Name ="Episode:59"}, new ValidationModel { Name ="Episode:58", } } },
                                    new ValidationModel() { Key = 9, Name = "Data Media", Children = new ObservableCollection<ValidationModel>() { new ValidationModel { Name = "Episode:60" }, new ValidationModel { Name ="Episode:59"}, new ValidationModel { Name ="Episode:58", } } },
                                     new ValidationModel() { Key = 10, Name = "Download", Children = new ObservableCollection<ValidationModel>() { new ValidationModel { Name = "Episode:60" }, new ValidationModel { Name ="Episode:59"}, new ValidationModel { Name ="Episode:58", } } },
                                      new ValidationModel() { Key = 11, Name = "Electronics Claims", Children = new ObservableCollection<ValidationModel>() { new ValidationModel { Name = "Episode:60" }, new ValidationModel { Name ="Episode:59"}, new ValidationModel { Name ="Episode:58", } } },
                                       new ValidationModel() { Key = 12, Name = "Electroni Claim Generation", Children = new ObservableCollection<ValidationModel>() { new ValidationModel { Name = "Episode:60" }, new ValidationModel { Name ="Episode:59"}, new ValidationModel { Name ="Episode:58", } } },
                                        new ValidationModel() { Key = 13, Name = "Electroni Remittance", Children = new ObservableCollection<ValidationModel>() { new ValidationModel { Name = "Episode:60" }, new ValidationModel { Name ="Episode:59"}, new ValidationModel { Name ="Episode:58", } } },
                                         new ValidationModel() { Key = 14, Name = "Eligibility", Children = new ObservableCollection<ValidationModel>() { new ValidationModel { Name = "Episode:60" }, new ValidationModel { Name ="Episode:59"}, new ValidationModel { Name ="Episode:58", } } },
                                          new ValidationModel() { Key = 15, Name = "Email", Children = new ObservableCollection<ValidationModel>() { new ValidationModel { Name = "Episode:60" }, new ValidationModel { Name ="Episode:59"}, new ValidationModel { Name ="Episode:58", } } },
                                           new ValidationModel() { Key = 16, Name = "File Transfer", Children = new ObservableCollection<ValidationModel>() { new ValidationModel { Name = "Episode:60" }, new ValidationModel { Name ="Episode:59"}, new ValidationModel { Name ="Episode:58", } } },
                                            new ValidationModel() { Key = 17, Name = "GlobalSync", Children = new ObservableCollection<ValidationModel>() { new ValidationModel { Name = "Episode:60" }, new ValidationModel { Name ="Episode:59"}, new ValidationModel { Name ="Episode:58", } } },
                                             new ValidationModel() { Key = 18, Name = "Group Appeal", Children = new ObservableCollection<ValidationModel>() { new ValidationModel { Name = "Episode:60" }, new ValidationModel { Name ="Episode:59"}, new ValidationModel { Name ="Episode:58", } } },
                                              new ValidationModel() { Key = 19, Name = "Image Import", Children = new ObservableCollection<ValidationModel>() { new ValidationModel { Name = "Episode:60" }, new ValidationModel { Name ="Episode:59"}, new ValidationModel { Name ="Episode:58", } } },
                                              new ValidationModel() { Key = 20, Name = "Image Processing", Children = new ObservableCollection<ValidationModel>() { new ValidationModel { Name = "Episode:60" }, new ValidationModel { Name ="Episode:59"}, new ValidationModel { Name ="Episode:58", } } },
                                              new ValidationModel() { Key = 21, Name = "Insurance Building", Children = new ObservableCollection<ValidationModel>() { new ValidationModel { Name = "Episode:60" }, new ValidationModel { Name ="Episode:59"}, new ValidationModel { Name ="Episode:58", } } },



            };

        }

    }
}
