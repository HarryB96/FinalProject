using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SpartanTrainingRoom.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [StringLength(50)]
        public string CourseName { get; set; }
    }
}
