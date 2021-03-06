using System;
using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using frameWorkInfragistic.Infrastructure;

namespace frameWorkInfragistic.ViewModels
{
    public class TabChild1ViewModel : AppMapViewModelBase, IActiveAware
    {

#pragma warning disable 67
        public event EventHandler IsActiveChanged;
#pragma warning restore 67

        public bool IsActive { get; set; }

        public TabChild1ViewModel(INavigationService navigationService) : base (navigationService)
        {
        }
    }
}
