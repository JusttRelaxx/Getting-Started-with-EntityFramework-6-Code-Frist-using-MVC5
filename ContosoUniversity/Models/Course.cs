using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)] /*this attribute lets you 
                                                           * enter the primary key for the course
                                                           * rather than having the database generate it. */
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public virtual Enrollment Enrollments { get; set; }

    }
}