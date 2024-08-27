using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Model 
{
    public class Person
    {
        [Key]
        public int PersonId { get; set;}
        public string? FullName { get; set;}
        
    }
}