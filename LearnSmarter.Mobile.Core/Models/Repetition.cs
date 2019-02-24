using System;
using System.Collections.Generic;
using System.Text;

namespace LearnSmarter.Mobile.Core.Models
{
    public class Repetition
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public DateTime? NextDate { get; set; }
        public DateTime TimeAmount { get; set; }
        public Ratings Rating { get; set; }
    }
}
