﻿using Android.Content;
using Android.Support.Design.Widget;
using Duolingo.Droid.Renderers;
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
                var relativeLayout = base.GetChildAt(0) as Android.Widget.RelativeLayout;
                var bottomNavigationView = relativeLayout.GetChildAt(1) as BottomNavigationView;
                bottomNavigationView.SetMinimumHeight(350);
            }
        }
    }
}