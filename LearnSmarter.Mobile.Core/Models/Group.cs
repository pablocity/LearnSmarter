using LearnSmarter.Mobile.Core.ViewModels;
using MvvmCross.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace LearnSmarter.Mobile.Core.Models
{
    public class Group<TKey, TElement> : ObservableCollection<TElement>
    {
        public IMvxCommand ExpandOrCollapseCommand => new MvxCommand(ExpandOrCollapse);
        public TKey Key { get; private set; }

        private List<TElement> lastState;
        private readonly HomeViewModel vm;

        private bool isExpanded;
        public bool IsExpanded
        {
            get
            {
                return isExpanded;
            }
            set
            {
                isExpanded = value;

            }
        }

        public Group(TKey key, List<TElement> elements)
        {
            Key = key;
            lastState = new List<TElement>(elements);
            IsExpanded = false;
            //elements.ForEach(x => Items.Add(x));
        }

        public Group(TKey key, List<TElement> elements, HomeViewModel viewModel)
        {
            Key = key;
            lastState = new List<TElement>(elements);
            IsExpanded = false;
            vm = viewModel;
            //elements.ForEach(x => Items.Add(x));
        }

        private void Expand()
        {
            foreach (TElement item in lastState)
            {
                Items.Add(item);
            }

            IsExpanded = true;

            Group<LearningSubject, Repetition> ls = vm.Subjects[vm.Subjects.Count - 1];
            vm.Subjects.RemoveAt(vm.Subjects.Count - 1);
            vm.Subjects.Add(ls);
            vm.RaisePropertyChanged("Subjects");
            
        }

        private void Collapse()
        {
            lastState = new List<TElement>(Items);
            Items.Clear();
            IsExpanded = false;

            Group<LearningSubject, Repetition> ls = vm.Subjects[vm.Subjects.Count - 1];
            vm.Subjects.RemoveAt(vm.Subjects.Count - 1);
            vm.Subjects.Add(ls);

            vm.RaisePropertyChanged("Subjects");
        }

        private void ExpandOrCollapse()
        {
            if (IsExpanded)
                Collapse();
            else
                Expand();
        }
    }
}
