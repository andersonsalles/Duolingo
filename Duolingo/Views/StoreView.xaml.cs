using Duolingo.Interfaces;
using Duolingo.Views.TitleViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Duolingo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StoreView : ContentPage, IDynamicTitle
    {
        private View _title;
        public StoreView()
        {
            InitializeComponent();
        }

        public View GetTitle()
        {
            if (_title == null)
            {
                _title = new StoreTitleView();
            }
            return _title;
        }
    }
}