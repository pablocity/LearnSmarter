using LearnSmarter.Mobile.Core.ViewModels;
using MvvmCross.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearnSmarter.Mobile.Core.Models
{
    public class MenuItem
    {
        public string Name { get; private set; }
        public string ImagePath { get; private set; }
        public Type NavigationTarget { get; private set; }

        public MenuItem(string name, string imagePath, Type navigationTargetType)
        {
            Name = name;
            ImagePath = imagePath;
            NavigationTarget = navigationTargetType;
        }
    }
}
