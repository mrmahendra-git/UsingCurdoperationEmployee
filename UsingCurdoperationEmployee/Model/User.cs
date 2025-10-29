
using System.ComponentModel.DataAnnotations;

namespace UsingCurdoperationEmployee.Model
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public required string UserName { get; set; }
        public required string Usermail { get; set; }
        public required string UserPassword { get; set; }
        public required string UserAge { get; set; }
        public required string UserDob { get; set; }
        
    }
}
