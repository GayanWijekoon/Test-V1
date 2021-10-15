using System;

namespace CodingChallenge.SeniorDev.V1.Common.DTO
{
    public class CourseModel
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string TeacherFullName { get; set; }
        public string Subject { get; set; }
        public int CurrentStudentCount { get; set; }
        public int MaximumStudentLimit { get; set; }
        public bool CanEnrollMoreStudents => MaximumStudentLimit <= CurrentStudentCount;
    }
}
