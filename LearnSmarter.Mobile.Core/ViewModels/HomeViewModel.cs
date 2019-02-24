using LearnSmarter.Mobile.Core.Models;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Linq;

namespace LearnSmarter.Mobile.Core.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public IMvxAsyncCommand AddLSCommand => new MvxAsyncCommand(AddLS);
        public IMvxCommand SortByPriorityCommand => new MvxCommand(SortPriorities);

        public async Task AddLS()
        {
            LearningSubject result = await NavigationService.Navigate<LearningSubject>(typeof(LSAddViewModel));

            if (result != null)
                Collection.Add(result);
        }

        public void SortPriorities()
        {
            Collection = new ObservableCollection<LearningSubject>(Collection.OrderBy(x => x.Priority));
        }

        private ObservableCollection<LearningSubject> collection;
        public ObservableCollection<LearningSubject> Collection
        {
            get => collection;
            set => SetProperty(ref collection, value);
        }

        public HomeViewModel()
        {
            Collection = new ObservableCollection<LearningSubject>()
            {
                new LearningSubject("Nazwa", System.DateTime.Now)
            };

        }
    }
}
