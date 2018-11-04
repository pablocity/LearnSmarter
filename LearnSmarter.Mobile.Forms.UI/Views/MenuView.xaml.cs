using LearnSmarter.Mobile.Core.ViewModels;
using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LearnSmarter.Mobile.Forms.UI.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxMasterDetailPagePresentation(MasterDetailPosition.Master)]
    [MvxViewFor(typeof(MenuViewModel))]
    public partial class MenuView : MvxContentPage
	{
		public MenuView ()
		{
			InitializeComponent ();
		}

        protected override void OnViewModelSet()
        {
            base.OnViewModelSet();
            MenuViewModel viewModel = ViewModel as MenuViewModel;
            viewModel.PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == nameof(viewModel.SelectedItem))
                {
                    if (Parent is MasterDetailPage master)
                    {
                        master.IsPresented = !master.IsPresented;
                    }
                }
            };
        }
    }
}