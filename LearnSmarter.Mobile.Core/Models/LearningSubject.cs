using System;
using System.Collections.Generic;
using System.Text;

namespace LearnSmarter.Mobile.Core.Models
{
    public class LearningSubject
    {
        public string Name { get; private set; }
        public Category Category { get; private set; }
        public string Description { get; set; }
        public bool IsObligatory { get; set; }
        public Priority Priority { get; set; }
        public List<Note> Notes { get; private set; }
        public List<Repetition> Repetitions { get; private set; } //TODO Change to priority queue based on repetition priority
        public Repetition NextRepetition { get => Repetitions[0]; } //TODO Change to peek function
        public DateTime? Deadline { get; private set; }

        public LearningSubject(string name, DateTime? deadline = null)
        {
            Name = name;
            Deadline = deadline;
        }

        public LearningSubject(string name, string description, Category category, Priority priority, DateTime? deadline = null)
        {
            Name = name;
            Description = description;
            Category = category;
            Priority = Priority;
            Deadline = deadline;
        }

        private void CalculateNextRepetition()
        {

        }
    }
}
