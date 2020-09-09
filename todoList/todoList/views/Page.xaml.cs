using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace todoList.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page : MasterDetailPage
    {
        public Page()
        {
            InitializeComponent();
            /*MasterPage.ListView.ItemSelected += ListView_ItemSelected;*/
          
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (PageMasterMenuItem)e.SelectedItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = new NavigationPage(page);

            IsPresented = false;
            MasterPage.ListView.SelectedItem = null;
        }
    }
}