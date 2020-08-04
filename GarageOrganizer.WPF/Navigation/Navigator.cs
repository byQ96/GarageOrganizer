using GarageOrganizer.WPF.Commands;
using GarageOrganizer.WPF.Models;
using GarageOrganizer.WPF.ViewModels;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace GarageOrganizer.WPF.Navigation
{
    public class Navigator : Observable, INavigator
    {
        private BaseViewModel _currentViewModel;
        public BaseViewModel CurrentViewModel 
        { 
            get 
            {
                return _currentViewModel;
            } 
            set
            {
                _currentViewModel = value;
                OnPropertyChanged(nameof(CurrentViewModel));
            }
        }
        public ICommand UpdateCurrentViewModelCommand => new UpdateCurrentViewModelCommand(this);
    }
}
