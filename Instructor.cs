using System;
using System.Collections.Generic;

namespace Csharp_CohortExercise
{

    public class Instructor
    {
        public Instructor(string first, string last, string slack, string specialty, int cohort)
        {
            _firstName = first;
            _lastName = last;
            _slack = slack;
            _speciality = specialty;
            _cohort = cohort;
        }

        string _firstName { get; }
        public Cohort CurrentCohort { get; set; }
        public void AssignExercise(Student student, Exercise exercise)
        {
            student.Exercises.Add(exercise);
        }
        private string _lastName { get; }
        private string _slack { get; }
        private string _speciality { get; }
        public int _cohort { get; set; }
    }
}