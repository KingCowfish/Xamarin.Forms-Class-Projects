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
    public partial class MessageCenter : ContentPage
    {
        public MessageCenter()
        {
            InitializeComponent();
        }

        void OnClick(object sender, System.EventArgs e)
        {
            var page = new TargetPage();
            //page.SliderValueChanged += OnSliderValueChanged;
            MessagingCenter.Subscribe<TargetPage, double>(this, Events.SliderValueChanged, OnSliderValueChanged);

            Navigation.PushAsync(page);

            MessagingCenter.Unsubscribe<MessagingCenter>(this, "SliderValueChanged");
        }

        private void OnsliderValueChanged(TargetPage source, double newValue)
        {
            label.Text = newValue.ToString();
        }
    }
}