using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
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

            PopupNavigation.Instance.PopAsync();
        }
    }
}