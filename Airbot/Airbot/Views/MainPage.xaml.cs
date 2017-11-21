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

        public MainPage()
        {
            InitializeComponent();
            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = LoadAsset("Airbot.Assets.haofu.html");
            webview.Source = htmlSource;
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
