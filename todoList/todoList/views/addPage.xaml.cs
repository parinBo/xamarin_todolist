using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace todoList
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class addPage 
    {
        public addPage()
        {
            InitializeComponent();

        }
       
        private  void Button_Clicked(object sender, System.EventArgs e)
        {
            App.Database.SavePersonAsync(new views.Person { FirstName = FirstName.Text, LastName = LastName.Text ,
                Detail = Detail.Text,StartDate = startDatePicker.Date,EndDate = endDatePicker.Date});
            Navigation.PopAsync();
        }
        void OnDateSelected(object sender, DateChangedEventArgs args)
        {
            TimeSpan timeSpan = endDatePicker.Date - startDatePicker.Date;
            resultLabel.Text = String.Format("{0} day{1} between dates",
                                             timeSpan.Days, timeSpan.Days == 1 ? "" : "s");
        }
    }
}