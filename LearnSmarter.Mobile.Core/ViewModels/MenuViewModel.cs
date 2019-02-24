using LearnSmarter.Mobile.Core.Models;
using MvvmCross.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace LearnSmarter.Mobile.Core.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {
        public ObservableCollection<MenuItem> MenuItems { get; set; }

        //private IMvxAsyncCommand selectionChanged;
        public IMvxAsyncCommand<MenuItem> SelectionChangedCommand;

        private MenuItem selectedItem;
        public MenuItem SelectedItem
        {
            get => selectedItem;
            set
            {
                if (SetProperty(ref selectedItem, value))
                    SelectionChangedCommand.Execute(value);
            }
        }

        public MenuViewModel()
        {
            MenuItems = new ObservableCollection<MenuItem>()
            {
                new MenuItem("Twoja nauka", "knowledge.png", typeof(HomeViewModel)),
                new MenuItem("Planer", "planning.png", typeof(PlannerViewModel)),
                new MenuItem("Osiągnięcia", "award.png", typeof(LSAddViewModel)),
                new MenuItem("Ustawienia", "settings.png", typeof(HomeViewModel)),
            };

            SelectionChangedCommand = new MvxAsyncCommand<MenuItem>(NavigateToMenuItem);
        }

        private async Task NavigateToMenuItem(MenuItem item)
        {
            if (item == null)
                return;

            Type viewModelType = item.NavigationTarget;

            await NavigationService.Navigate(viewModelType);
        }

    }
}
