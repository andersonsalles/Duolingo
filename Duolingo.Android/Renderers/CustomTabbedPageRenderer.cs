﻿using Android.Content;
using Android.Support.Design.BottomNavigation;
using Android.Support.Design.Widget;
using Duolingo.Droid.Renderers;
using Duolingo.Interfaces;
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
        private TabbedPage _formsTabs;
        private BottomNavigationView _bottomNavigationView;

        public CustomTabbedPageRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<TabbedPage> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                _formsTabs = Element;
                _formsTabs.CurrentPageChanged += OnCurrentPageChanged;
                var relativeLayout = base.GetChildAt(0) as Android.Widget.RelativeLayout;
                _bottomNavigationView = relativeLayout.GetChildAt(1) as BottomNavigationView;
                _bottomNavigationView.SetMinimumHeight(350);
                _bottomNavigationView.ItemIconTintList = null;
                _bottomNavigationView.ItemIconSize = 150;
                _bottomNavigationView.SetShiftMode(false,false);
                _bottomNavigationView.LabelVisibilityMode = LabelVisibilityMode.LabelVisibilityUnlabeled;
                UpdateAllTabs();
            }

            if (e.OldElement != null)
            {
                _formsTabs.CurrentPageChanged -= OnCurrentPageChanged;
            }
        }

        private void UpdateAllTabs()
        {
            for (int index = 0; index < _formsTabs.Children.Count; index++)
            {
                var androidTab = _bottomNavigationView.Menu.GetItem(index);
                int iconId;
                if (_formsTabs.Children[index] is ITabPageIcons tabPage)
                {
                    if (_formsTabs.Children[index] == _formsTabs.CurrentPage)
                    {
                        iconId = GetIconIdByFileName(tabPage.GetSelectedIcon());
                        androidTab.SetIcon(iconId);
                        continue;
                    }
                    iconId = GetIconIdByFileName(tabPage.GetIcon());
                    androidTab.SetIcon(iconId);
                    continue;
                }

            }
        }

        private int GetIconIdByFileName(string fileName)
        {
            return Resources.GetIdentifier(fileName, "drawable", Context.PackageName);
        }

        private void OnCurrentPageChanged(object sender, EventArgs e)
        {
            UpdateAllTabs();
        }
    }
}