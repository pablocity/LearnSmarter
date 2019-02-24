using LearnSmarter.Mobile.Core.Models;
using MvvmCross;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LearnSmarter.Mobile.Core.ViewModels
{
    public class BaseViewModelWithResult : MvxViewModel<BaseViewModel, LearningSubject>
    {
        public BaseViewModel Parameter { get; set; }

        public MvxNotifyTask TaskNotifier { get; set; }
        protected IMvxNavigationService NavigationService { get; set; }

        public BaseViewModelWithResult()
        {
            NavigationService = Mvx.IoCProvider.Resolve<IMvxNavigationService>();
        }

        protected void LogError(Exception ex)
        {
            throw new NotImplementedException();
        }
        //public TaskCompletionSource<object> CloseCompletionSource { get => null; set => CloseCompletionSource = null; }

        public override void Prepare(BaseViewModel parameter)
        {
            Parameter = parameter;
        }
    }
}
