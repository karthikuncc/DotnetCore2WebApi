using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeDetails.API.Models

{
    public class Employees
    {
        [Key]
        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
         [Column(TypeName = "decimal(9, 2)")]
        public decimal Basesalary {get;set;}
        [Column(TypeName = "decimal(9, 2)")]
        public decimal C401k {get;set;}
        [Column(TypeName = "decimal(9, 2)")]
        public decimal Medical {get;set;}
        [Column(TypeName = "decimal(9, 2)")]
        public decimal Vision {get;set;}
        [Column(TypeName = "decimal(9, 2)")]
         public decimal Dental {get;set;}
         [Column(TypeName = "decimal(9, 2)")]
         private decimal takeHome;
           [Column(TypeName = "decimal(9, 2)")]
         public decimal? TakeHome {
             get { return takeHome; }
             set { takeHome = Basesalary-C401k-Medical-Vision-Dental; }
        }
	
        
    }
}