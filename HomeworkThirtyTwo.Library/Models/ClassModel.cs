using System;
using System.Collections.Generic;

namespace HomeworkThirtyTwo.Library.Models
{
    public class ClassModel
    {
        public event EventHandler<string> EnrollmentFull;

        private List<string> enrolledList = new List<string>();
        private List<string> waitingList = new List<string>();

        public string Subject { get; private set; }
        public int MaximumSlots { get; private set; }

        public ClassModel(string subject, int maximumSlots)
        {
            Subject = subject;
            MaximumSlots = maximumSlots;
        }

        public string EnrollStudent(string student)
        {
            string output = "";

            if (enrolledList.Count < MaximumSlots)
            {
                enrolledList.Add(student);
                output = $"{student} is enrolled for {Subject}";

                if (enrolledList.Count == MaximumSlots)
                {
                    EnrollmentFull?.Invoke(this, $"Enrollment Full");
                }
            }
            else
            {
                waitingList.Add(student);
                output = $"{student} is added in the wait list for {Subject}";
            }

            return output;
        }
    }
}
