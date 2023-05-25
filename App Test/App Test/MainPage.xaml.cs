using Xamarin.Forms;

namespace App_Test
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            LoadWebPage();
        }

        private void LoadWebPage()
        {
            var webUrl = "https://anchorsbook.com";

            webView.Source = new UrlWebViewSource { Url = webUrl };
        }
    }
}
