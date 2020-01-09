using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SpartanTrainingRoom.Models;

namespace SpartanTrainingRoom.ViewModels
{
    public class AdminViewModel
    {
        public AdminViewModel(IEnumerable<User> Users, IEnumerable<Course> Courses)
        {
            this.Users = Users.ToList<User>();
            this.Courses = Courses.ToList<Course>();
        }
        public List<User> Users { get; set; }
        public List<Course> Courses { get; set; }
    }
}
