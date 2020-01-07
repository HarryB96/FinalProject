using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanTrainingRoom.Models
{
    public class Login
    {
        TrainingDbModel model;
        public bool ValidateUser(string email, string password)
        {
            var selectedUser = model.Users.Select(u => u).Where<User>(u => u.Email == email && u.UserPassword == password);
            if (selectedUser.Count() == 1)
                return true;
            else
                return false;
        }
    }
}
