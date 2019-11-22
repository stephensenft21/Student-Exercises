using System;
using System.Collections.Generic;

namespace StudentExercises
{

    public class Cohort
    {

        public Cohort(string name)
        {

            Name = name;

        }

        public string Name {get;}
        public List<Student> StudentList {get; set;} = new List<Student>();
        public List<Instructor> InstructorList {get; set;} = new List <Instructor>();

    }

}