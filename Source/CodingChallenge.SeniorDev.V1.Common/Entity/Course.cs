using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodingChallenge.SeniorDev.V1.Common.Entity
{
    public class Course
    {
        public Guid ID { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public Guid TeacherID { get; set; }
        [Required]
        public Guid SubjectID { get; set; }
        [Required]
        public int MaximumStudentLimit { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Teacher Teacher { get; set; }
        public virtual Subject Subject { get; set; }

        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
