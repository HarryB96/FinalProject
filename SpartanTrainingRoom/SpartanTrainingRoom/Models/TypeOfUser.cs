using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SpartanTrainingRoom.Models
{
    public class TypeOfUser
    {
        [Key]
        public int TypeId { get; set; }
        [StringLength(20)]
        public string TypeName { get; set; }
        public bool CanEditUsers { get; set; }
        public bool CanAddAdmins { get; set; }
    }
}
