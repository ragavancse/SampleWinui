using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using SampleWinui.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace SampleWinui.CommonControls
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PaginationControl : UserControl, INotifyPropertyChanged
    {
        public PaginationControl()
        {
            this.InitializeComponent();

        }

        #region Properties

        public int CurrentPageIndex = 0;
        public int ItemPerPage = 10;

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
                    bool isInt = int.TryParse(value, out int valueInt);
                    ItemPerPage = isInt ? valueInt : ItemPerPage;
                    UpdateTotalPageCount();
                }
            }
        }

        private int _CurrentPage;

        public int CurrentPage
        {
            get { return _CurrentPage; }
            set
            {
                _CurrentPage = value;              
                if (value == 1)
                {
                    btnFirst.IsEnabled = false;
                    btnPrev.IsEnabled = false;
                    btnFirst.Opacity = 0.3;
                    btnPrev.Opacity = 0.3;
                 }
                else
                {
                    btnFirst.IsEnabled = true;
                    btnPrev.IsEnabled = true;
                    btnFirst.Opacity = 1;
                    btnPrev.Opacity = 1;
                }

                if(value == TotalPage)
                {
                    btnNext.IsEnabled= false;
                    btnLast.IsEnabled = false;
                    btnNext.Opacity = 0.3;
                    btnLast.Opacity = 0.3;
                }
                else
                {
                    btnNext.IsEnabled = true;
                    btnLast.IsEnabled = true;
                    btnNext.Opacity = 1;
                    btnLast.Opacity = 1;
                }
                RaisePropertyChanged(nameof(CurrentPage));
            }
        }

        private int _TotalPage;

        public int TotalPage
        {
            get { return _TotalPage; }
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

        #endregion

        #region Event Handlers

        private void btnFirst_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentPageIndex != 0)
                CurrentPageIndex = 0;

            RunPageSizeUpdate();
        }

        private void btnPrev_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentPageIndex > 0)
                CurrentPageIndex--;

            ShowCurrentPageIndex();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentPageIndex < TotalPage - 1)
                CurrentPageIndex++;

            ShowCurrentPageIndex();
        }

        private void btnLast_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentPageIndex != TotalPage - 1)
                CurrentPageIndex = TotalPage - 1;

            ShowCurrentPageIndex();
        }

        private void RunPageSizeUpdate()
        {
            if (Source.Count() > 0)
                UpdateTotalPageCount();
        }

        private void ShowCurrentPageIndex()
        {
            if (Source.Count() > 0)
            {
                FilteredSource = new ObservableCollection<object>(Source.Skip(CurrentPageIndex * ItemPerPage).Take(ItemPerPage));
                CurrentPage = CurrentPageIndex + 1;
                CurrentPageStart = (CurrentPageIndex * ItemPerPage) + 1;
                CurrentPageEnd = (CurrentPageIndex + 1) * ItemPerPage > TotalItems ? TotalItems : (CurrentPageIndex + 1) * ItemPerPage;
               
            }
        }

        public void UpdateTotalPageCount()
        {
            CurrentPageIndex = 0;
            TotalPage = Source.Count() % ItemPerPage == 0 ? Source.Count() / ItemPerPage : Source.Count() / ItemPerPage + 1;
            ShowCurrentPageIndex();
        }

        #endregion Event Handlers

        #region Dependency Properties

        public IEnumerable<object> Source
        {
            get { return (IEnumerable<object>)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }

        public static readonly DependencyProperty SourceProperty =
        DependencyProperty.Register("Source",
                                typeof(IEnumerable<>),
                                typeof(PaginationControl),
                                new PropertyMetadata(null, new PropertyChangedCallback(SourceChanged)));

        private static void SourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            PaginationControl ctrl = d as PaginationControl;
            if (ctrl != null)
            {
                ctrl.TotalItems = ctrl.Source.Count();
                ctrl.UpdateTotalPageCount();
            }
        }

        public IEnumerable<object> FilteredSource
        {
            get { return (IEnumerable<object>)GetValue(FilteredSourceProperty); }
            set { SetValue(FilteredSourceProperty, value); }
        }

        public static readonly DependencyProperty FilteredSourceProperty =
        DependencyProperty.Register("FilteredSource", typeof(IEnumerable<>), typeof(PaginationControl), new PropertyMetadata(null));

        #endregion Dependency Properties

        #region NotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
