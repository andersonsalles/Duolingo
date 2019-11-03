using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Duolingo.iOS.Renderers;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(TabbedPage), typeof(CustomTabbedPageRenderer))]  
namespace Duolingo.iOS.Renderers
{
    class CustomTabbedPageRenderer : TabbedRenderer
    {
        public override void ViewDidLayoutSubviews()
        {
            base.ViewDidLayoutSubviews();
            var tabFrame  = TabBar.Frame;
            var viewFrame = View.Frame;

            var tabHeight = 150;
            tabFrame.Height = tabHeight;
            tabFrame.Y = View.Frame.Height - 150;
            View.Frame = viewFrame;
        }
    }
}