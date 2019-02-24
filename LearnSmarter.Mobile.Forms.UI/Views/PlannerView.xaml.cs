using MvvmCross.Forms.Views;
using MvvmCross.Forms.Presenters.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MvvmCross.ViewModels;
using LearnSmarter.Mobile.Core.ViewModels;

namespace LearnSmarter.Mobile.Forms.UI.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxMasterDetailPagePresentation(MasterDetailPosition.Detail, NoHistory = true)]
    [MvxViewFor(typeof(PlannerViewModel))]
	public partial class PlannerView : MvxContentPage
	{
		public PlannerView ()
		{
			InitializeComponent ();
		}
	}
}