using Duolingo.Interfaces;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Duolingo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TrainingView : ContentPage, ITabPageIcons
    {
        public TrainingView()
        {
            InitializeComponent();
        }

        public string GetIcon()
        {
            return "tab_training";
        }

        public string GetSelectedIcon()
        {
            return "tab_training_selected";
        }
    }
}