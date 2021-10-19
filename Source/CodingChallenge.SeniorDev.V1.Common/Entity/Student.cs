using System;
using System.ComponentModel.DataAnnotations;

namespace CodingChallenge.SeniorDev.V1.Common.Entity
{
    public class Student
    {
        public Guid ID { get; set; }
        [Required]
        public string RegistrationID { get; set; }
        [MaxLength(30)]
        [Required]
        public string FirstName { get; set; }
        [MaxLength(30)]
        [Required]
        public string LastName { get; set; }
        public DateTimeOffset Birthdate { get; set; }
        public string Email { get; set; }
        public string NICNo { get; set; }
        public bool IsDeleted { get; set; }
    }
}
