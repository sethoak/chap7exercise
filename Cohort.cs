using System;
using System.Collections.Generic;

namespace Csharp_CohortExercise
{

    public class Cohort
    {
        public List<Student> Students = new List<Student>();

        public Cohort(string name)
        {
            _name = name;
        }

        public string _name;

        public List<Student> StudentList = new List<Student>();
        public List<Instructor> InstructorList = new List<Instructor>();
        internal object students;
    }
}