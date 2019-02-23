using LearnSmarter.Mobile.Core.Models;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace LearnSmarter.Mobile.Core.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public IMvxAsyncCommand AddLSCommand => new MvxAsyncCommand(AddLS);

        public async Task AddLS()
        {
            LearningSubject result = await NavigationService.Navigate<LearningSubject>(typeof(LSAddViewModel));

            if (result != null)
                Collection.Add(result);
        }

        public ObservableCollection<LearningSubject> Collection { get; set; }

        public HomeViewModel()
        {
            Collection = new ObservableCollection<LearningSubject>()
            {
                new LearningSubject("Nazwa", System.DateTime.Now)
            };

        }
    }
}
