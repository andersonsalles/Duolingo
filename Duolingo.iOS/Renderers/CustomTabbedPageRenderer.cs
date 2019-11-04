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
            if (page is LessonsView)
            {
                return await Task.FromResult(
                    new Tuple<UIImage, UIImage>(
                        GetImageFromFile("tab_lessons.png"),
                        GetImageFromFile("tab_lessons_selected.png")
                     )
                );
            }

            if (page is TrainingView)
            {
                return await Task.FromResult(
                    new Tuple<UIImage, UIImage>(
                        GetImageFromFile("tab_training.png"),
                        GetImageFromFile("tab_training_selected.png")
                     )
                );
            }

            if (page is ProfileView)
            {
                return await Task.FromResult(
                    new Tuple<UIImage, UIImage>(
                        GetImageFromFile("tab_profile.png"),
                        GetImageFromFile("tab_profile_selected.png")
                     )
                );
            }

            if (page is RankingView)
            {
                return await Task.FromResult(
                    new Tuple<UIImage, UIImage>(
                        GetImageFromFile("tab_ranking.png"),
                        GetImageFromFile("tab_ranking_selected.png")
                     )
                );
            }

            if (page is StoreView)
            {
                return await Task.FromResult(
                    new Tuple<UIImage, UIImage>(
                        GetImageFromFile("tab_store.png"),
                        GetImageFromFile("tab_store_selected.png")
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