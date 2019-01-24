using LearnSmarter.Mobile.Core.Models;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace LearnSmarter.Mobile.Core.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public IMvxCommand ResetTextCommand => new MvxCommand(ResetText);
        public IMvxAsyncCommand AddLSCommand => new MvxAsyncCommand(AddLS);

        private void ResetText()
        {
            Text = "Hello MvvmCross";
        }

        public async Task AddLS()
        {
            int i = 0;
            LearningSubject result = await NavigationService.Navigate<LearningSubject>(typeof(LSAddViewModel));

            if (result != null)
                Collection.Add(result);
        }

        private string _text = "Hello MvvmCross";
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }

        public ObservableCollection<LearningSubject> Collection { get; set; }

        public HomeViewModel()
        {
            Collection = new ObservableCollection<LearningSubject>();
        }
    }
}
