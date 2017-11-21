using System;
using Android.App;
using Android.Views;
using Airbot.Droid.Renderers;
using Airbot.Views.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using static Android.Webkit.WebSettings;

[assembly: ExportRenderer(typeof(MyWebView), typeof(MyWebViewRenderer))]

namespace Airbot.Droid.Renderers
{
    public class MyWebViewRenderer : WebViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<WebView> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement != null)
            {
                // Unsubscribe from event handlers and cleanup any resources
            }

            if (e.NewElement != null)
            {
                
                // Configure the control and subscribe to event handlers
                if (Control != null)
                {
                    //Control.Settings.JavaScriptEnabled = (true);
                    //Control.Settings.LoadWithOverviewMode = (true);
                    //Control.Settings.UseWideViewPort = (false);

                    //Control.HorizontalScrollBarEnabled = false;
                    //var window = ((Activity)Forms.Context).Window;
                    //window.SetSoftInputMode(SoftInput.AdjustResize);
                }
            }
        }

    }
}
