
using Rg.Plugins.Popup.Services;
using System;
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
        public void onAddPopupClick(object s,EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new Popuppage());
        }
    }
}