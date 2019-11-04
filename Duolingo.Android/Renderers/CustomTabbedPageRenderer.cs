using Android.Content;
using Android.Support.Design.Widget;
using Duolingo.Droid.Renderers;
using Duolingo.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Platform.Android.AppCompat;

[assembly: ExportRenderer(typeof(TabbedPage), typeof(CustomTabbedPageRenderer))]
namespace Duolingo.Droid.Renderers
{
    class CustomTabbedPageRenderer: TabbedPageRenderer
    {
        public CustomTabbedPageRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<TabbedPage> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                var formsTabs = Element;
                var relativeLayout = base.GetChildAt(0) as Android.Widget.RelativeLayout;
                var bottomNavigationView = relativeLayout.GetChildAt(1) as BottomNavigationView;
                bottomNavigationView.SetMinimumHeight(350);
                bottomNavigationView.ItemIconTintList = null;
                bottomNavigationView.ItemIconSize = 150;

                for (int index = 0; index < formsTabs.Children.Count; index++)
                {
                    var androidTab = bottomNavigationView.Menu.GetItem(index);

                    if (formsTabs.Children[index] is LessonsView)
                    {
                        if (formsTabs.Children[index] == formsTabs.CurrentPage)
                        {
                            androidTab.SetIcon(Resource.Drawable.tab_lessons_selected);
                            continue;
                        }
                        androidTab.SetIcon(Resource.Drawable.tab_lessons);
                        continue;
                    }
                    if (formsTabs.Children[index] is ProfileView)
                    {
                        if (formsTabs.Children[index] == formsTabs.CurrentPage)
                        {
                            androidTab.SetIcon(Resource.Drawable.tab_profile_selected);
                            continue;
                        }
                        androidTab.SetIcon(Resource.Drawable.tab_profile);
                        continue;
                    }
                    if (formsTabs.Children[index] is RankingView)
                    {
                        if (formsTabs.Children[index] == formsTabs.CurrentPage)
                        {
                            androidTab.SetIcon(Resource.Drawable.tab_ranking_selected);
                            continue;
                        }

                        androidTab.SetIcon(Resource.Drawable.tab_ranking);
                        continue;
                    }
                    if (formsTabs.Children[index] is StoreView)
                    {
                        if (formsTabs.Children[index] == formsTabs.CurrentPage)
                        {
                            androidTab.SetIcon(Resource.Drawable.tab_store_selected);
                            continue;
                        }
                        androidTab.SetIcon(Resource.Drawable.tab_store);
                        continue;
                    }

                }
            }
        }
    }
}