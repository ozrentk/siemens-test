using System.ComponentModel;

namespace Task12.Models.User
{
    public class VMLogin
    {
        [DisplayName("User name")]
        public string Username { get; set; }
        [DisplayName("Password")]
        public string Password { get; set; }
        [DisplayName("Stay Signed-in")]
        public bool StaySignedIn { get; set; }
        public string? RedirectUrl { get; set; }
    }
}
