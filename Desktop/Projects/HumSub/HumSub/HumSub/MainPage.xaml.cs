using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HumSub
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            }

        void Button_Clicked(object sender, EventArgs e)  //function handler for the guest sign in button 
        {
            Navigation.PushAsync(new NewMainPage());
        }

        void Button_Clicked2(object sender, EventArgs e) //function handler for the User sign in button 
        {
            Navigation.PushAsync(new LoginPage());
        }
    }
}
