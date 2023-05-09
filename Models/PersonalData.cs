using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Task12.Models
{
    public class PersonalData
    {
        [DisplayName("First Name")]
        [Required]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required]
        public string LastName { get; set; }

        [DisplayName("E-mail")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [DisplayName("Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        [DisplayName("Can we send updates?")]
        public bool SendUpdates { get; set; }
    }
}
