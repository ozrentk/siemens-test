using System.ComponentModel;

namespace Task12.Models.User
{
    public class VMChangePassword
    {
        [DisplayName("User name")]
        public string Username { get; set; }
        [DisplayName("Password")]
        public string Password { get; set; }
        [DisplayName("Confirm Password")]
        public string Password2 { get; set; }
    }
}
