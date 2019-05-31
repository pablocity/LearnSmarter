using LearnSmarter.Mobile.Core.Models;
using MvvmCross.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LearnSmarter.Mobile.Common;
using System.Collections.ObjectModel;

namespace LearnSmarter.Mobile.Core.ViewModels
{
    public class LSAddViewModel : BaseViewModelWithResult
    {
        public IMvxAsyncCommand CloseView { get; set; }
        public IMvxAsyncCommand ApproveCommand { get; set; }

        private string name;

        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value, Name); }
        }

        private string descritpion;
        public string Description
        {
            get { return descritpion; }
            set { SetProperty(ref descritpion, value, Description); }
        }

        private DateTime deadline;
        public DateTime Deadline
        {
            get => deadline;
            set => SetProperty(ref deadline, value);
        }

        private Priority priority;
        public Priority Priority
        {
            get => priority;
            set { Priority p = (Priority)value; SetProperty(ref priority, p); }
        }

        public Category Category { get; private set; }

        public ObservableCollection<string> Priorities { get; set; }


        public LSAddViewModel()
        {
            CloseView = new MvxAsyncCommand(Close);
            ApproveCommand = new MvxAsyncCommand(Add);
            Deadline = DateTime.Now;

            Priority = Priority.Average;
            Priorities = new ObservableCollection<string>(EnumHelper.GetEnumValuesDescriptionList<Priority>());
        }

        public async Task Close()
        {
            await NavigationService.Close(this);
        }

        public async Task Add()
        {
            LearningSubject ls = new LearningSubject(Name, Description, Category, Priority, Deadline);
            ////TODO Add to a local database 
            ////TODO Close adding page
            await NavigationService.Close<LearningSubject>(this, ls);
            ////TODO Refresh Main page
        }
    }
}
