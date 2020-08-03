using GarageOrganizer.WPF.Commands;
using GarageOrganizer.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace GarageOrganizer.WPF.Navigation
{
    public class Navigator: INavigator
    {
        public BaseViewModel CurrentViewModel { get; set; }
        public ICommand UpdateCurrentViewModelCommand => new UpdateCurrentViewModelCommand(this);
    }
}
