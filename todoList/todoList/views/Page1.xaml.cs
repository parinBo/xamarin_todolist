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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }
        void OnDateSelected(object sender, DateChangedEventArgs args)
        {
            TimeSpan timeSpan = endDatePicker.Date - startDatePicker.Date;
            resultLabel.Text = String.Format("{0} day{1} between dates",
                                             timeSpan.Days, timeSpan.Days == 1 ? "" : "s");
        }

       
    }
}