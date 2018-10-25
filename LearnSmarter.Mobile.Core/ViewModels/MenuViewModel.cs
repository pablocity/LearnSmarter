using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace LearnSmarter.Mobile.Core.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {
        public ObservableCollection<string> MenuItems { get; set; }

        public MenuViewModel()
        {
            MenuItems = new ObservableCollection<string>()
            {
                "Twoja nauka",
                "Planer",
                "Osiągnięcia",
                "Ustawienia",
            };
        }
    }
}
