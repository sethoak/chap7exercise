using System;
using System.Collections.Generic;

namespace Csharp_CohortExercise
{
    public class Student
    {
        public Student(string first, string last, string slack)
        {
            _firstName = first;
            _lastName = last;
            _slack = slack;
        }

        public string _firstName { get; }
        public string _lastName { get; }
        public string _slack { get; }
        public Cohort CurrentCohort { get; set; }
        public List<Exercise> Exercises = new List<Exercise>();
    }
}