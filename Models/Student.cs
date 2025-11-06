using System.ComponentModel.DataAnnotations;
namespace StudentRecordsApp.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string? FullName { get; set; }

        [Required]
        public string? Department { get; set; }

        [Range(16, 40)]
        public int Age { get; set; }

        [EmailAddress]
        public string? Email { get; set; }
    }
}
