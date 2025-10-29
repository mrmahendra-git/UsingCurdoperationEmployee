using System.ComponentModel.DataAnnotations;

namespace UsingCurdoperationEmployee.Model.Entity
{
    public class Employee
    
        {
        [Key]
        public int EmpId { get; set; }
        public required string EmpName { get; set; }
        public required string EmpEmail { get; set; }
        public  required string  Empphone { get; set; }
        public decimal EmpSal { get; set; }

    }
}