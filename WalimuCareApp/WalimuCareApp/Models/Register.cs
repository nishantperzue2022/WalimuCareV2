

using System;

namespace WalimuCareApp.Models
{
    internal class Register
    {
        public Guid Id { get; set; }
        public string MemberNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public byte? Status { get; set; }
        public byte IsAccountCreated { get; set; }
        public byte IsAccountExist { get; set; }
        public byte IsMemberExist { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
