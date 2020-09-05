
using Rg.Plugins.Popup.Services;
using System;
using System.Collections;
using todoList.views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace todoList
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Listpage : ContentPage
    {
        public Listpage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            lvShow.ItemsSource = await App.Database.GetPeopleAsync();
           
        }

        public void onAddPopupClick(object s,EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new Popuppage());
        }

        private void item_click(object sender, SelectedItemChangedEventArgs e)
        {
            Navigation.PushAsync(new DetailPage { BindingContext = e.SelectedItem as Person});
        }

        private async void deleteClick(object sender, EventArgs e)
        {
            var getData = await App.Database.GetPeopleAsync();
            Console.WriteLine("asdsad" + getData.ToString());

            //Console.WriteLine(App.Database.findDataToDelete(this.BindingContext.ToString));
        }
    }
}