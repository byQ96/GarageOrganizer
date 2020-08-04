using GarageOrganizer.WPF.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace GarageOrganizer.WPF.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public INavigator Navigator { get; set; } = new Navigator();
    }
}
