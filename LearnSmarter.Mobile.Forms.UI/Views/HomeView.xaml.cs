using MvvmCross.Forms.Views;
using Xamarin.Forms.Xaml;
using MvvmCross.Forms.Presenters.Attributes;

namespace LearnSmarter.Mobile.Forms.UI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxMasterDetailPagePresentation(MasterDetailPosition.Detail, NoHistory = true)]
	public partial class HomeView : MvxContentPage
	{
		public HomeView ()
		{
			InitializeComponent ();
		}
	}
}