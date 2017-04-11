using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PushNoti
{
    public partial class MainPage : ContentPage
    {
        public MainPage(string msg)
        {
            InitializeComponent();
            asd.Text = msg;
            if (msg != "")
            {
                DisplayAlert("Displayed", msg, "Ok");
            }
        }
    }
}
