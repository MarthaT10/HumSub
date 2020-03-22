using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HumSub
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage()); //in order to create a mutli-page app, xamarin needs the navigation toolbar
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
