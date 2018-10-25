using MvvmCross;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearnSmarter.Mobile.Core.ViewModels
{
    public class BaseViewModel : MvxViewModel
    {
        public MvxNotifyTask TaskNotifier { get; set; }
        protected IMvxNavigationService NavigationService { get; set; }

        public BaseViewModel()
        {
            NavigationService = Mvx.IoCProvider.Resolve<IMvxNavigationService>();
        }

        protected void LogError(Exception ex)
        {
            throw new NotImplementedException();
        }
    }
}
