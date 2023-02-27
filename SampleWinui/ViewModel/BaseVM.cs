using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleWinui.ViewModel
{
    public class BaseVM : INotifyPropertyChanged
    {
        public BaseVM()
        {
        }

        public int CurrentPageIndex = 0;
        public int ItemPerPage = 10;

        public ICommand FirstPageCommand { get; set; }
        public ICommand NextPageCommand { get; set; }
        public ICommand PrevPageCommand { get; set; }
        public ICommand LastPageCommand { get; set; }
        public ICommand PageSizeUpdateCommand { get; set; }

        private List<string> _PageSizeList = new() { "10", "20", "50", "100", "250" };
        public List<string> PageSizeList
        {
            get
            {
                return _PageSizeList;
            }
            set
            {
                _PageSizeList = value;
                RaisePropertyChanged(nameof(PageSizeList));
            }
        }

        private string _PageSize = "10";

        public string PageSize
        {
            get
            {
                return _PageSize;
            }
            set
            {
                _PageSize = value;
                if (!string.IsNullOrWhiteSpace(value))
                {
                    bool isInt = Int32.TryParse(value, out int valueInt);
                    ItemPerPage = isInt ? valueInt : ItemPerPage;
                    PageSizeUpdateCommand?.Execute(null);
                }
                RaisePropertyChanged(nameof(PageSize));
            }
        }

        private int _CurrentPage;

        public int CurrentPage
        {
            get
            {
                return _CurrentPage;
            }
            set
            {
                _CurrentPage = value;
                RaisePropertyChanged(nameof(CurrentPage));
            }
        }

        private int _TotalPage;

        public int TotalPage
        {
            get
            {
                return _TotalPage;
            }
            set
            {
                _TotalPage = value;
                RaisePropertyChanged(nameof(TotalPage));
            }
        }

        private int _CurrentPageStart;

        public int CurrentPageStart
        {
            get { return _CurrentPageStart; }
            set
            {
                _CurrentPageStart = value;
                RaisePropertyChanged(nameof(CurrentPageStart));
            }
        }

        private int _CurrentPageEnd;

        public int CurrentPageEnd
        {
            get { return _CurrentPageEnd; }
            set
            {
                _CurrentPageEnd = value;
                RaisePropertyChanged(nameof(CurrentPageEnd));
            }
        }

        private int _TotalItems;

        public int TotalItems
        {
            get { return _TotalItems; }
            set
            {
                _TotalItems = value;
                RaisePropertyChanged(nameof(TotalItems));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
