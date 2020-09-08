
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
            this.BindingContext = App.Database.GetPeopleAsync();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            lvShow.ItemsSource = await App.Database.GetPeopleAsync();
           
        }

        public void onAddPopupClick(object s,EventArgs e)
        {
            Navigation.PushAsync(new Popuppage { BindingContext=  new Person() });
        }

        private void item_click(object sender, SelectedItemChangedEventArgs e)
        {
            Navigation.PushAsync(new DetailPage { BindingContext = e.SelectedItem as Person});
        }

       
    }
}