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

        public ObservableCollection<Group<LearningSubject, Repetition>> Subjects { get; set; }

        public async Task AddLS()
        {
            LearningSubject result = await NavigationService.Navigate<LearningSubject>(typeof(LSAddViewModel));
            Group<LearningSubject, Repetition> resultGroup = new Group<LearningSubject, Repetition>(result, result.Repetitions, this);

            if (result != null)
            {
                //Collection.Add(result);
                Subjects.Add(resultGroup);
            }
                
        }

        public void SortPriorities()
        {
            Subjects = new ObservableCollection<Group<LearningSubject, Repetition>>(Subjects.OrderBy(x => x.Key.Priority)); 
        }

        public HomeViewModel()
        {
            Subjects = new ObservableCollection<Group<LearningSubject, Repetition>>();
        }
    }
}
