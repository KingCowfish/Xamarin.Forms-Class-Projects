using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AbsExercise
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new Exercise1();
            MainPage = new Exercise2();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
