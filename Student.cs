using System;
using System.Collections.Generic;

namespace Csharp_CohortExercise
{
    public class Student
    {
        public Student(string first, string last, string slack, int cohort, int exercise, bool work)
        {
            _firstName = first;
            _lastName = last;
            _slack = slack;
            _cohort = cohort;
            _exercise = exercise;
            _work = work;
        }

        public string _firstName { get; }
        public string _lastName { get; }
        public string _slack { get; }
        public int _cohort { get; set; }
        public int _exercise { get; set; }
        public Cohort CurrentCohort { get; set; }
        public bool _work { get; set; }
        public List<Exercise> Exercises = new List<Exercise>();
    }
}