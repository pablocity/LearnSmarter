using MvvmCross.Commands;
using MvvmCross.ViewModels;

namespace LearnSmarter.Mobile.Core.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public IMvxCommand ResetTextCommand => new MvxCommand(ResetText);
        private void ResetText()
        {
            Text = "Hello MvvmCross";
        }

        private string _text = "Hello MvvmCross";
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }
    }
}
