using System;

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
            Student JamesMcClarty = new Student("James", "McClarty", "james-mcclarty");

            Instructor AdamSheaffer = new Teacher("Adam", "Sheaffer", "adam-sheaffer", "back-end");
            Instructor BrendaLong = new Teacher("Brenda", "Long", "brenda-long", "front-end");
            Instructor MoSilvera = new Teacher("Mo", "Silvera", "mo-silvera", "front-end");
        }
    }
}