using MvvmCross.IoC;
using MvvmCross.ViewModels;
using LearnSmarter.Mobile.Core.ViewModels;

namespace LearnSmarter.Mobile.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDEyNDRAMzEzNjJlMzMyZTMwT001Nmk3aGljeUlxanYvakpXWks5aWYvRmM1WnJ2SmQ0ekZEZU1JUVRYWT0=");

            RegisterTypes();

            RegisterAppStart<RootMenuViewModel>();
        }

        private void RegisterTypes()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
        }
    }
}
