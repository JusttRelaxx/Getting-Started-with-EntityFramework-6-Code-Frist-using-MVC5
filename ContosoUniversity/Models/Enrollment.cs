using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; } // ? after grade means that the Grade can be nullable.

        //Navigation properties
        public virtual Course Course {get;set;}
        public virtual Student Student { get; set; }
    }
}