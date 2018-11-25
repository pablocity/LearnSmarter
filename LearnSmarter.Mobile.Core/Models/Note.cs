using System;
using System.Collections.Generic;
using System.Text;

namespace LearnSmarter.Mobile.Core.Models
{
    public class Note
    {
        public string Content { get; set; }
        public List<string> Tags { get; set; }

        public Note(string content)
        {
            Content = content;
        }
    }
}
