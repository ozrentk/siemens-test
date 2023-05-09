using System.ComponentModel;

namespace Task12.Models.User
{
    public class VMValidateEmail
    {
        public string Email { get; set; }
        public string SecurityToken { get; set; }
    }
}
