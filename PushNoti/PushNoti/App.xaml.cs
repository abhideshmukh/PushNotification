using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PushNoti
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PushNoti.MainPage("");
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            if(!string.IsNullOrEmpty(Helpers.Settings.GeneralSettings))
            {
                string msg = Helpers.Settings.GeneralSettings;
                //MainPage = new PushNoti.MainPage(msg);

                if(Helpers.Settings.Notification.Equals ("MainPage"))
                    MainPage = new PushNoti.MainPage(msg);


                if (Helpers.Settings.Notification.Equals("Page1"))
                    MainPage = new PushNoti.Page1(msg);
            }


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
