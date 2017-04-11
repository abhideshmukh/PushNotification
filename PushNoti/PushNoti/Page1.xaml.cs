using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PushNoti
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1(string msg)
        {
            InitializeComponent();

            if (msg != "")
            {
                DisplayAlert("Displayed", msg, "Ok");
            }
        }
    }
}
