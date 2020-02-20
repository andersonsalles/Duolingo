using System;
using Duolingo.Controls;
using Android.Support.Design.Widget;
using Android.Content;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Duolingo.Droid.Renderers;
using Android.Content.Res;
using Duolingo.Droid.Utils;

[assembly: ExportRenderer(typeof(FormsFloatingActionButton), typeof(FormsFloatActionButtonRenderer))]
namespace Duolingo.Droid.Renderers
{
    public class FormsFloatActionButtonRenderer : Xamarin.Forms.Platform.Android.AppCompat.ViewRenderer<FormsFloatingActionButton, FloatingActionButton>
    {
        private FloatingActionButton _floatingActionButton;


        public FormsFloatActionButtonRenderer(Context context) : base (context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<FormsFloatingActionButton> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                _floatingActionButton = new FloatingActionButton(Context);
                _floatingActionButton.UseCompatPadding = true;
                
                ConfigureBackgroundColor();
                ConfigureImage();
                _floatingActionButton.Click += OnFabClick;
                SetNativeControl(_floatingActionButton);
            }
            
        }

        private void ConfigureBackgroundColor()
        {
            if (Element is null)
            {
                return;
            }
            var floatActionButtonColor = Element.BackgroundColor.ToAndroid();
            _floatingActionButton.BackgroundTintList = ColorStateList.ValueOf(floatActionButtonColor);
            Element.BackgroundColor = Color.Transparent;

        }

        private void OnFabClick(object sender, EventArgs e)
        {
            Element?.Command?.Execute(null);
        }

        private void ConfigureImage()
        {
            if (Element == null)
            {
                return;
            }
            var fileName = (Element.ImageSource as FileImageSource)?.File;
            if (fileName == null)
            {
                return;
            }
            //var resourceId = Resources.GetIdentifier(fileName, "drawable", Context.PackageName);
            var resourceId = ResourceUtil.GetDrawableIdByFileName(fileName, Context);
            _floatingActionButton.SetImageResource(resourceId);
        }
    }
}

