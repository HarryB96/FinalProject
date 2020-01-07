using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SpartanTrainingRoom.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [StringLength(20)]
        public string FirstName { get; set; }
        [StringLength(20)]
        public string LastName { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(20)]
        public string UserPassword { get; set; }
        public int? CurrentScore { get; set; }
        public int? MaxScore { get; set; }
        public DateTime? EndDate { get; set; }
        public int TypeId { get; set; }
        public int? CourseId { get; set; }
    }
}
