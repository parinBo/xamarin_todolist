using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace todoList.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageMaster : ContentPage
    {
        public ListView ListView;

        public PageMaster()
        {
            InitializeComponent();

            BindingContext = new PageMasterViewModel();
        }

        class PageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<PageMasterMenuItem> MenuItems { get; set; }

            public PageMasterViewModel()
            {
                MenuItems = new ObservableCollection<PageMasterMenuItem>(new[]
                {
                    new PageMasterMenuItem { Id = 0, Title = "Page 1" },
                    new PageMasterMenuItem { Id = 1, Title = "Page 2" },
                    new PageMasterMenuItem { Id = 2, Title = "Page 3" },
                    new PageMasterMenuItem { Id = 3, Title = "Page 4" },
                    new PageMasterMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}