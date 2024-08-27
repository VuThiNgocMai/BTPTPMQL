using System.ComponentModel.DataAnnotations;
namespace DemoMVC.Models
{
    public class Student

    {
        [Key]
        public string? Fullname {get; set;}
        public string? Address {get; set;}
    }
}