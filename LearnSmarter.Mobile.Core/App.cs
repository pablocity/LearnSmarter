using MvvmCross.IoC;
using MvvmCross.ViewModels;
using LearnSmarter.Mobile.Core.ViewModels;

namespace LearnSmarter.Mobile.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<HomeViewModel>();
        }
    }
}
