using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using Microsoft.Azure.Mobile.Push;

namespace App3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new App3.MainPage();
        }

        protected override void OnStart()
        {
            MobileCenter.Start("uwp=17d33792-c435-4c4a-9ac2-3cd1cf07355e;" +
                   "android=9aace377-b5c9-4ca3-8491-77b48df3a481;" +
                   "ios=b79f79e0-096f-47a3-af4c-ba7305ba7593;",
                   typeof(Analytics), typeof(Crashes), typeof(Push));
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
