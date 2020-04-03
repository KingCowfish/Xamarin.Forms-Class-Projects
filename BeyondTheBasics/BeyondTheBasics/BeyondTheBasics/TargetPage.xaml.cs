using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BeyondTheBasics
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TargetPage : ContentPage
    {
        public TargetPage()
        {
            InitializeComponent();
        }

        void OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            MessagingCenter.Send(this, Events.SliderValueChanged, e.NewValue);
        }
    }
}