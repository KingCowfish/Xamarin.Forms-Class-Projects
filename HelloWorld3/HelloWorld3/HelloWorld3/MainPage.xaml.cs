using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloWorld3
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            var app = Application.Current as App;

            BindingContext = Application.Current;
        }

        //private void OnChange(object sender, EventArgs e)
        //{
        //    var app = Application.Current as App;
        //    app.Title = title.Text;
        //    app.NotificationsEnabled = notificationsEnabled.On;

        //    Application.Current.SavePropertiesAsync();
        //    Good for saving data immediately e.g. long bits of input.
        //}

        //protected override void OnDisappearing()
        //{
        //    base.OnDisappearing();
        //}
        //save when navigating away from page
    }
}
