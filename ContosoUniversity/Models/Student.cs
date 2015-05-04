using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        [Column("FirstName")]  //In the Database, the FirstMidName property will be represented as FirstName
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyy-MM-dd}", ApplyFormatInEditMode = true)] //the second param is not recomended in
        [Display(Name="Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }


        [Display(Name="Full Name")]
        public string FullName
        {
            get
            {
                return LastName + "," + FirstMidName;
            }
        }

        //Navigation property, Collection of student's all enrollments
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}