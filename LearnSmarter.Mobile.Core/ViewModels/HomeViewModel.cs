using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System.Collections.ObjectModel;

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

        public ObservableCollection<string> Collection { get; set; }

        public HomeViewModel()
        {
            Collection = new ObservableCollection<string>()
            {
                "1",
                "2",
                "3",
                "4",
                "5",
            };
        }
    }
}
