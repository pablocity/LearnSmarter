using MvvmCross.Forms.Views;
using Xamarin.Forms.Xaml;

namespace LearnSmarter.Mobile.Forms.UI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomeView : MvxContentPage
	{
		public HomeView ()
		{
			InitializeComponent ();
		}
	}
}