using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_Test
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ShowSplashScreen();
        }

        private async void ShowSplashScreen()
        {
            // Create a new layout to hold the splash screen content
            var layout = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            };

            /*
            // Create an image view for the logo
            var logoImage = new Image
            {
                Source = "img/ablogo.png" // Replace "logo.png" with the actual file name and extension of your logo
            };
            layout.Children.Add(logoImage);

            // Set the layout as the content of the page
            Content = layout;

            // Add a delay to simulate the splash screen display time
            await Task.Delay(4000); // Adjust the delay time as needed

            // After the delay, load the web page
            LoadWebPage();*/

            var splashText = new Label
            {
                Text = "Anchorsbook.com",
                FontSize = 24,
                HorizontalTextAlignment = TextAlignment.Center
            };
            layout.Children.Add(splashText);

            // Set the layout as the content of the page
            Content = layout;

            // Add a delay to simulate the splash screen display time
            await Task.Delay(2000); // Adjust the delay time as needed

            // After the delay, load the web page
            LoadWebPage();
        }

        private void LoadWebPage()
        {
            var webUrl = "https://anchorsbook.com";

            // Create a web view and set the source to the desired URL
            var webView = new WebView
            {
                Source = new UrlWebViewSource { Url = webUrl }
            };

            // Set the web view as the content of the page
            Content = webView;
        }
    }
}
