using GarageOrganizer.WPF.Enums;
using GarageOrganizer.WPF.Navigation;
using GarageOrganizer.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace GarageOrganizer.WPF.Commands
{
    public class UpdateCurrentViewModelCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private readonly INavigator _navigator;

        public UpdateCurrentViewModelCommand(INavigator navigator)
        {
            _navigator = navigator;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is ViewType)
            {
                var viewType = (ViewType)parameter;

                switch (viewType)
                {
                    case ViewType.Cars:
                        _navigator.CurrentViewModel = new CarsViewModel();
                        break;
                    case ViewType.Clients:
                        _navigator.CurrentViewModel = new ClientsViewModel();
                        break;
                    case ViewType.Calendar:
                        break;
                }
            }
        }
    }
}