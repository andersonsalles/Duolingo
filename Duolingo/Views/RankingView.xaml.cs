using Duolingo.Interfaces;
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
    public partial class RankingView : ContentPage, ITabPageIcons
    {
        public RankingView()
        {
            InitializeComponent();
        }

        public string GetIcon()
        {
            return "tab_ranking";
        }

        public string GetSelectedIcon()
        {
            return "tab_ranking_selected";
        }
    }
}