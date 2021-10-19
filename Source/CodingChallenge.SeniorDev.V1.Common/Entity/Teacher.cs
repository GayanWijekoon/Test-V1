using System;
using System.ComponentModel.DataAnnotations;

namespace CodingChallenge.SeniorDev.V1.Common.Entity
{
    public class Teacher
    {
        public Guid ID { get; set; }
        [MaxLength(30)]
        public string FirstName { get; set; }
        [MaxLength(30)]
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public DateTimeOffset Birthdate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
