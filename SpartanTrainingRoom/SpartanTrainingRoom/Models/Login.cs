using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanTrainingRoom.Models
{    
    public class Login
    {
        TrainingDbModel model;
        public void ValidateUser(string email)
        {
            model.Users.Where<User>(u => u.Email == email);
        }
    }
}
