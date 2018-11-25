using System;
using System.Collections.Generic;
using System.Text;

namespace LearnSmarter.Mobile.Core.Models
{
    public class LearningSubject
    {
        public string Name { get; private set; }
        public string Category { get; private set; }
        public string Description { get; set; }
        public List<Note> Notes { get; private set; }
        public List<Repetition> Repetitions { get; private set; }
        public Repetition NextRepetition { get; private set; }
        public DateTime? Deadline { get; private set; }

        public LearningSubject()
        {

        }
    }
}
