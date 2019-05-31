using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LearnSmarter.Mobile.Core.Models
{
    public class Repetition : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public DateTime? NextDate { get; set; }
        public DateTime TimeAmount { get; set; }
        public Ratings Rating { get; set; }

        public Repetition(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
