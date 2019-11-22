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
            Exercise exercise5 = new Exercise("OverlyExcited", "HTML/CSS");
            Exercise exercise6 = new Exercise("SolarSystem", "C#");
            Exercise exercise7 = new Exercise("CarLot", "JS");
            Exercise exercise8 = new Exercise("DynamicCards", "C#, CSS, React");

            Cohort cohort1 = new Cohort("Cohort 33");
            Cohort cohort2 = new Cohort("Cohort 34");
            Cohort cohort3 = new Cohort("Cohort 35");

            Student SethOakley = new Student("Seth", "Oakley", "seth-oakley");
            Student DavidCornish = new Student("David", "Cornish", "david-cornish");
            Student HeidiSmith = new Student("Heidi", "Smith", "heidi-smith");
            Student LarryBird = new Student("Larry", "Bird", "larry-bird");
            Student KristinDavis = new Student("Kristin", "Davis", "kristin-davis");
            Student LoshannaD = new Student("Loshanna", "D", "loshanna-d");
            Student TreGupton = new Student("Tre", "Gupton", "tre-gupton");

            Instructor AdamSheaffer = new Instructor("Adam", "Sheaffer", "adam-sheaffer", "back-end");
            Instructor BrendaLong = new Instructor("Brenda", "Long", "brenda-long", "front-end");
            Instructor MoSilvera = new Instructor("Mo", "Silvera", "mo-silvera", "front-end");

            cohort1.StudentList.Add(SethOakley);
            cohort2.StudentList.Add(DavidCornish);
            cohort3.StudentList.Add(HeidiSmith);
            cohort1.StudentList.Add(LarryBird);
            cohort2.StudentList.Add(KristinDavis);
            cohort3.StudentList.Add(LoshannaD);
            cohort1.StudentList.Add(TreGupton);

            cohort1.InstructorList.Add(AdamSheaffer);
            cohort2.InstructorList.Add(BrendaLong);
            cohort3.InstructorList.Add(MoSilvera);

            AdamSheaffer.AssignExercise(SethOakley, exercise1);
            BrendaLong.AssignExercise(SethOakley, exercise4);
            BrendaLong.AssignExercise(DavidCornish, exercise2);
            MoSilvera.AssignExercise(SethOakley, exercise3);
            MoSilvera.AssignExercise(LarryBird, exercise5);
            AdamSheaffer.AssignExercise(LoshannaD, exercise6);
            AdamSheaffer.AssignExercise(LoshannaD, exercise7);
            AdamSheaffer.AssignExercise(LoshannaD, exercise8);



            List<Student> students = new List<Student>();
            students.Add(SethOakley);
            students.Add(DavidCornish);
            students.Add(HeidiSmith);
            students.Add(LarryBird);
            students.Add(KristinDavis);
            students.Add(LoshannaD);
            students.Add(TreGupton);

            List<Exercise> exercises = new List<Exercise>();
            exercises.Add(exercise1);
            exercises.Add(exercise2);
            exercises.Add(exercise3);
            exercises.Add(exercise4);
            exercises.Add(exercise5);
            exercises.Add(exercise6);
            exercises.Add(exercise7);
            exercises.Add(exercise8);

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