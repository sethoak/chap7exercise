using System;
using System.Collections.Generic;

namespace Csharp_CohortExercise
{
    public class Student
    {
        public Student(string first, string last, string slack, int cohort)
        {
            _firstName = first;
            _lastName = last;
            _slack = slack;
            _cohort = cohort;
        }

        public string _firstName { get; }
        public string cohortList { get; set; }
        public string _lastName { get; }
        public string _slack { get; }
        public int _cohort { get; set; }
        public Cohort CurrentCohort { get; set; }
        public List<Exercise> Exercises = new List<Exercise>();
    }
}