using System.ComponentModel.DataAnnotations;

namespace GradeManagement.Models
{
    public class StudentLoginViewModel
    {

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
