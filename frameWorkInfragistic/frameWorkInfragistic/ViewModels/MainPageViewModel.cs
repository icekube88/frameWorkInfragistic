using System;
using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using frameWorkInfragistic.Infrastructure;

namespace frameWorkInfragistic.ViewModels
{
    public class MainPageViewModel : AppMapViewModelBase
    {


        public MainPageViewModel(INavigationService navigationService) : base (navigationService)
        {
        }
    }
}
