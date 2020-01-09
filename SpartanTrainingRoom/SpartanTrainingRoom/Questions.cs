using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SpartanTrainingRoom.Models
{
    public class Questions
    {
        [Key]
       public int QuestionId { get; set; }
       public string QuestionContent { get; set; }
       public string Answer { get; set; }
       public bool Completed { get; set; }
        
    }
    
   
    
   

}
