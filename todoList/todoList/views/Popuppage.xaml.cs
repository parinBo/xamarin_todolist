using Rg.Plugins.Popup.Services;
using Xamarin.Forms.Xaml;

namespace todoList
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Popuppage 
    {
        public Popuppage()
        {
            InitializeComponent();

        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            App.Database.SavePersonAsync(new views.Person { FirstName = FirstName.Text, LastName = LastName.Text });

            PopupNavigation.Instance.PopAsync();
        }
    }
}