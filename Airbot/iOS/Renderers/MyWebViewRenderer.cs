using System;
using Airbot.iOS.Renderers;
using Airbot.Views.Controls;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MyWebView), typeof(MyWebViewRenderer))]
namespace Airbot.iOS.Renderers
{
    public class MyWebViewRenderer : WebViewRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
            if (e.OldElement != null)
            {
                // Unsubscribe from event handlers and cleanup any resources

                var control = (NativeView as UIWebView);
                //if (control != null)
                    //control.ScrollView.Scrolled -= HandleEventHandler;
            }

            if (e.NewElement != null)
            {
                var control = (NativeView as UIWebView);
                // Configure the control and subscribe to event handlers
                if (control != null)
                {
                    //control.ScrollView.ShowsHorizontalScrollIndicator = false;
                    //control.ScrollView.Scrolled += HandleEventHandler;
                    //control.ScrollView.ContentSize = new CoreGraphics.CGSize(control.Frame.Size.Width, control.Frame.Size.Height);
                    //control.ScrollView.ContentInsetAdjustmentBehavior = UIScrollViewContentInsetAdjustmentBehavior.Never;

                }
            }
        }

        void HandleEventHandler(object sender, EventArgs e)
        {
            var scrollView = sender as UIScrollView;
            if (scrollView != null && scrollView.ContentOffset.X > 0)
                scrollView.ContentOffset = new CoreGraphics.CGPoint(0, scrollView.ContentOffset.Y);
        }
    }
}
