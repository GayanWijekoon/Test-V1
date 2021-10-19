using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.SeniorDev.V1.Common.Entity
{
    public class StudentCourse
    {
        public Guid ID { get; set; }
        [Required]
        public Guid StudentID { get; set; }
        [Required]
        public Guid CourseID { get; set; }
        [Required]
        public DateTimeOffset EnrolledDate { get; set; }
        public string Remark { get; set; }

        public virtual Student Student { get; set; }
        public virtual Course Courses { get; set; }
    }
}
