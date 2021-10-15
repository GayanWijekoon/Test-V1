using System;

namespace CodingChallenge.SeniorDev.V1.Common.Entity
{
    public class Student
    {
        public Guid ID { get; set; }
        public string RegistrationID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset Birthdate { get; set; }
        public string Email { get; set; }
        public string NICNo { get; set; }
        public bool IsDeleted { get; set; }
    }
}
