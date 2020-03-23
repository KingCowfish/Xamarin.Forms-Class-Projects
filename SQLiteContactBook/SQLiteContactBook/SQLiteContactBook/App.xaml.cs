﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SQLiteContactBook
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ContactsPage();
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
