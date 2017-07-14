using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Microsoft.Azure.Mobile.Crashes;
using Microsoft.Azure.Mobile.Analytics;

namespace App3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCrash_Clicked(object sender, EventArgs e)
        {
            Crashes.GenerateTestCrash();
        }

        private void btnClickEvent_Clicked(object sender, EventArgs e)
        {
            Analytics.TrackEvent("btnClick");
        }
    }
}
