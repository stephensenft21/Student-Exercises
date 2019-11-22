using System;
using System.Collections.Generic;

namespace StudentExercises
{

    public class Student
    {

        //CONSTRUCTOR
        public Student(string first, string last, string slack, Cohort cohort)
        {

            FirstName = first;
            LastName = last;
            Slack = slack;
            StudentCohort = cohort;

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Slack { get; set; }
        public Cohort StudentCohort { get; set; }
        public List<Exercise> StudentExerciseList { get;set; } = new List<Exercise>();

    }

}