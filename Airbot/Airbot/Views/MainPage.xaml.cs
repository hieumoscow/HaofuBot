using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using Xamarin.Forms;

namespace Airbot.Views
{
    public partial class MainPage : ContentPage
    {
        public static Assembly Assembly = typeof(App).GetTypeInfo().Assembly;

        const string BotUrl = "https://haofu2.azurewebsites.net/";

        public MainPage()
        {
            InitializeComponent();
            //var htmlSource = new HtmlWebViewSource();
            //htmlSource.Html = LoadAsset("Airbot.Assets.haofu.html");
            //webview.Source = htmlSource;
            webview.Source = BotUrl;
            webview.Navigating += Webview_Navigating;
        }

        void Webview_Navigating(object sender, WebNavigatingEventArgs e)
        {
            
            if (!e.Url.Equals(BotUrl) && e.Url.StartsWith("http", StringComparison.Ordinal))
            {
                Device.OpenUri(new Uri(e.Url));
                e.Cancel = true;
            }
        }

        public static string LoadAsset(string resId)
        {
            var stream = Assembly.GetManifestResourceStream(resId);
            try
            {
                using (var reader = new StreamReader(stream))
                {
                    var text = reader.ReadToEnd();
                    return text;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception: App.LoadAsset " + e.Message);
            }
            return null;
        }
    }
}
