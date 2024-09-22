using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
{
    [Table("Persons")]
    public class Employee
    {
        [Key]
        public string? EmployeeId { get; set;}
        public string? Fullname { get; set;}
    }
}