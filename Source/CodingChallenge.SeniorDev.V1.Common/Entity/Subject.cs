using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.SeniorDev.V1.Common.Entity
{
    public class Subject
    {
        public Guid ID { get; set; }
        [Required]
        public string SubjectName { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }

    }
}
