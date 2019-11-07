using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Duolingo.iOS.Renderers;
using Duolingo.Views;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Duolingo.Interfaces;

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

        protected override async Task<Tuple<UIImage, UIImage>> GetIcon(Page page)
        {
            if (page is ITabPageIcons tabPage)
            {
                return await Task.FromResult(
                    new Tuple<UIImage, UIImage>(
                        GetImageFromFile(tabPage.GetIcon()),
                        GetImageFromFile(tabPage.GetSelectedIcon())
                     )
                );
            }
            
            return await base.GetIcon(page);
        }

        private UIImage GetImageFromFile(string fileName)
        {
            return UIImage
                .FromFile(fileName)
                .ImageWithRenderingMode(UIImageRenderingMode.AlwaysOriginal);
        }
    }
}