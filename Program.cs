using System;
using System.Collections.Generic;
namespace StudentExercises
{
    class Program
    {
        /*
               1. Create 4, or more, exercises.
               2. Create 3, or more, cohorts.
               3. Create 4, or more, students and assign them to one of the cohorts.
               4. Create 3, or more, instructors and assign them to one of the cohorts.
               5. Have each instructor assign 2 exercises to each of the students.
           */
        static void Main(string[] args)
        {
            //Make 4 exercises using the exercise type 
            Exercise e1 = new Exercise("Objects", "javascript");
            Exercise e2 = new Exercise("Student Exercise", "c#");
            Exercise e3 = new Exercise("Kennel", "react.js");
            Exercise e4 = new Exercise("chickenMonkey", "javascript");

            Cohort c34 = new Cohort("c34");
            Cohort c35 = new Cohort("c35");
            Cohort c36 = new Cohort("c36");
            Cohort c39 = new Cohort("c39");

            Student Bill = new Student("Bill", "Brown", "Willy", c34);
            Student Hank = new Student("Hank", "Yellow", "where", c35);
            Student Sam = new Student("Sam", "Green", "what", c36);
            Student Gene = new Student("Gene", "ferdy", "who", c39);

            c34.StudentList.Add(Bill);
            c35.StudentList.Add(Hank);
            c36.StudentList.Add(Sam);
            c39.StudentList.Add(Gene);

            Instructor Adam = new Instructor("Adam", "shaffer", "shaffy", c35, "Eating IceCream");
            Instructor Jisie = new Instructor("Jisie", "Dont know", "hmmm", c39, "Coding");

            Instructor Maddie = new Instructor("Maddie", "slackname", "mads", c36, "dancing");
            Instructor Jenna = new Instructor("Jenna", "no clue", "Jenn", c34, "Beat boxing");

            //adding instructors to the list of instructors
            c35.InstructorList.Add(Adam);
            c36.InstructorList.Add(Maddie);
            c39.InstructorList.Add(Jisie);
            c34.InstructorList.Add(Jenna);

            // Cohort 35
            Adam.AssignExercise(Hank, e1);
            Adam.AssignExercise(Hank, e2);

            // Cohort 39
            Jisie.AssignExercise(Gene, e3);
            Jisie.AssignExercise(Gene, e4);

            // Cohort 34 
            Jenna.AssignExercise(Bill, e3);

            Jenna.AssignExercise(Bill, e4);

            /// Cohort 36
            Maddie.AssignExercise(Sam, e2);
            Maddie.AssignExercise(Sam, e1);

            List<Student> students = new List<Student>
            {
                Bill,
                Sam,
                Hank,
                Gene
            };

            List<Exercise> exercises = new List<Exercise>
            {
                e1,
                e2,
                e3,
                e4,

            };

            foreach (Student student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is working on these exercises:");
                foreach (Exercise studentExercise in student.StudentExerciseList)
                {
                    Console.WriteLine($"{studentExercise.Name}");
                }
                Console.WriteLine("");

            }

        }
    }
}