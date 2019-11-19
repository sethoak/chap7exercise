using System;
using System.Collections.Generic;

namespace Csharp_CohortExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise exercise1 = new Exercise("Create a for each loop.", "JS");
            Exercise exercise2 = new Exercise("Stylize the index.", "CSS");
            Exercise exercise3 = new Exercise("Develop an app.", "React");
            Exercise exercise4 = new Exercise("Build a website.", "HTML");

            Cohort cohort1 = new Cohort("Cohort 33");
            Cohort cohort2 = new Cohort("Cohort 34");
            Cohort cohort3 = new Cohort("Cohort 35");

            Student SethOakley = new Student("Seth", "Oakley", "seth-oakley");
            Student DavidCornish = new Student("David", "Cornish", "david-cornish");
            Student HeidiSmith = new Student("Heidi", "Smith", "heidi-smith");

            Instructor AdamSheaffer = new Instructor("Adam", "Sheaffer", "adam-sheaffer", "back-end");
            Instructor BrendaLong = new Instructor("Brenda", "Long", "brenda-long", "front-end");
            Instructor MoSilvera = new Instructor("Mo", "Silvera", "mo-silvera", "front-end");

            cohort1.StudentList.Add(SethOakley);
            cohort2.StudentList.Add(DavidCornish);
            cohort3.StudentList.Add(HeidiSmith);

            cohort1.InstructorList.Add(AdamSheaffer);
            cohort2.InstructorList.Add(BrendaLong);
            cohort3.InstructorList.Add(MoSilvera);

            AdamSheaffer.AssignExercise(SethOakley, exercise1);
            BrendaLong.AssignExercise(DavidCornish, exercise2);
            MoSilvera.AssignExercise(SethOakley, exercise3);

            List<Student> students = new List<Student>();
            students.Add(SethOakley);
            students.Add(DavidCornish);
            students.Add(HeidiSmith);

            List<Exercise> exercises = new List<Exercise>();
            exercises.Add(exercise1);
            exercises.Add(exercise2);
            exercises.Add(exercise3);

            foreach (Student student in students)
            {
                Console.WriteLine($"Student: {student._firstName} {student._lastName}");
                Console.WriteLine("Exercises:");
                foreach (Exercise exercise in student.Exercises)
                {
                    Console.WriteLine($"Program: {exercise._name} Language: {exercise._language}");
                }
            }
        }
    }
}