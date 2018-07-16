using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace POC_FlexLayout.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        int _count = 1;

        public ObservableCollection<string> Sources { get; }

        public MainPageViewModel(INavigationService navigationService) 
            : base (navigationService)
        {
            //asdads
            Title = "Main Page";
            Sources = new ObservableCollection<string>();

        }

        private DelegateCommand _addCommand;
        public DelegateCommand AddCommand =>
            _addCommand ?? (_addCommand = new DelegateCommand(ExecuteAddCommand));

        void ExecuteAddCommand()
        {
            Sources.Add("number "+_count);
            _count++;
        }

        private DelegateCommand<string> _removeCommand;
        public DelegateCommand<string> RemoveCommand =>
            _removeCommand ?? (_removeCommand = new DelegateCommand<string>(ExecuteRemoveCommand));

        void ExecuteRemoveCommand(string parameter)
        {
            Sources.Remove(parameter);
        }

    }
}
