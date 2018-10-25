using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LearnSmarter.Mobile.Core.ViewModels
{
    public class RootMenuViewModel : BaseViewModel
    {
        public RootMenuViewModel()
        {

        }

        public override void ViewAppearing()
        {
            base.ViewAppearing();

            this.TaskNotifier = MvxNotifyTask.Create(async () => await InitializeViewModels(), (e) => LogError(e));
        }

        private async Task InitializeViewModels()
        {
            await NavigationService.Navigate<MenuViewModel>();
            await NavigationService.Navigate<HomeViewModel>();
        }

    }
}
