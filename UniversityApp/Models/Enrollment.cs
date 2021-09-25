using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UniversityApp.Models
{
    public enum Grade
    {
        A,B,C,D,E,F
    }
    public class Enrollment
    {
        [Display(Name = "Enrollment ID")]
        public int EnrollmentID { get; set; }

        [Display(Name = "CXourse ID")]
        public int CourseID { get; set; }

        [Display(Name = "Student ID")]
        public int StudentID { get; set; }

        [Display(Name = "Grade")]
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }

        [Display(Name = "Course")]
        public Course Course { get; set; }

        [Display(Name = "Student")]
        public Student Student { get; set; }
    }
}