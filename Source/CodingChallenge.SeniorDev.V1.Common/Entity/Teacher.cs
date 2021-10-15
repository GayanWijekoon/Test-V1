using System;

namespace CodingChallenge.SeniorDev.V1.Common.Entity
{
    public class Teacher
    {
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTimeOffset Birthdate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
