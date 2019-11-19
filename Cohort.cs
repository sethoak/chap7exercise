using System;
using System.Collections.Generic;

namespace Csharp_CohortExercise
{

    public class Cohort
    {
        public Cohort(string name)
        {
            _name = name;
        }

        private string _name;

        public List<Student> StudentList = new List<Student>();
        public List<Instructor> StudentList = new List<Instructor>();
    }
}