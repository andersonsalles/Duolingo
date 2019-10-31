using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Duolingo.ViewModels
{
    
    class LessonsViewModel : ViewModelBase
    {
        public ICommand NavigateToTrainingCommand { get; private set; }

        public LessonsViewModel()
        {
            NavigateToTrainingCommand = new DelegateCommand(NavigateToTrainingExecute);
        }

        private void NavigateToTrainingExecute()
        {
            System.Diagnostics.Debug.WriteLine("O FAB foi selecionado");
        }
    }
}
