using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Duolingo.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            Children.Add(new LessonsView());
            if (Device.RuntimePlatform == Device.iOS)
            {
                Children.Add(new TrainingView());
            }
            Children.Add(new ProfileView());
            Children.Add(new RankingView());
            Children.Add(new StoreView());
            

            //        < TabbedPage.Children >
            //< views:LessonsView />
            //
            // < views:TrainingView />
            //
            //  < views:ProfileView />
            //
            //   < views:RankingView />
            //
            //    < views:StoreView />
            //
            // </ TabbedPage.Children >
        }
    }
}
