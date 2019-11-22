using System;
using System.Collections.Generic;

namespace StudentExercises
{

    public class Instructor
    {

        public Instructor(string first, string last, string slack, Cohort cohort, string specialty)
        {

            First = first;
            Last = last;
            Slack = slack;
            InstructorCohort = cohort;
            Specialty = specialty;



        }

        public string First {get; set;}
        public string Last {get; set;}
        public string Slack {get; set;}
        public Cohort InstructorCohort {get; set;}
        public string Specialty {get; set;}


        public void AssignExercise(Student student, Exercise exercise) {
           student.StudentExerciseList.Add(exercise);
           exercise.Students.Add(student);


        }



    }

}