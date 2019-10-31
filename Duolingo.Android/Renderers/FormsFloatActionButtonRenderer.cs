using System;
using Duolingo.Controls;
using Android.Support.Design.Widget;
using Android.Content;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Duolingo.Droid.Renderers;

[assembly: ExportRenderer(typeof(FormsFloatingActionButton), typeof(FormsFloatActionButtonRenderer))]
namespace Duolingo.Droid.Renderers
{
    public class FormsFloatActionButtonRenderer : Xamarin.Forms.Platform.Android.AppCompat.ViewRenderer<FormsFloatingActionButton, FloatingActionButton>
    {
        public FormsFloatActionButtonRenderer(Context context) : base (context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<FormsFloatingActionButton> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                var fab = new FloatingActionButton(Context);
                fab.UseCompatPadding = true;
                fab.Click += OnFabClick;
                SetNativeControl(fab);
            }
            
        }

        private void OnFabClick(object sender, EventArgs e)
        {
            Element?.Command?.Execute(null);
        }
    }
}

