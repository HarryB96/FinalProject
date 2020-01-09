using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanTrainingRoom.Models
{
    public class TrainingDbModel : DbContext
    {
        public TrainingDbModel(DbContextOptions<TrainingDbModel> options) : base(options)
        {

        }
        public virtual DbSet<TypeOfUser> TypeOfUser { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Course> Course { get; set; }
    }
}
