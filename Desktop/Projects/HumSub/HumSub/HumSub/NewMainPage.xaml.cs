using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HumSub
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewMainPage : ContentPage
    {
        public NewMainPage()        //adds the list for the picker of categories
        {
            InitializeComponent();
            MainPicker.Items.Add("Category: Urdo Columns");
            MainPicker.Items.Add("Category: Press");
            MainPicker.Items.Add("Category: Science");
            MainPicker.Items.Add("Category: Health");
            MainPicker.Items.Add("Category: Humour");
            MainPicker.Items.Add("Category: News");
            MainPicker.Items.Add("Category: Authors");

            Label header = new Label
            {
                Text = "Guest",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };

            WebView webView = new WebView
            {
                Source = new UrlWebViewSource
                {
                    Url = "https://en.humsub.com.pk/",
                },
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            // Accomodate iPhone status bar.
            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

            // Build the page.
            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    webView
                }
            };
        }
    }
}