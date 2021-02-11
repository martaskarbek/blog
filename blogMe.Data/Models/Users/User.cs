using System;

namespace blogMe.Data.Models.Users
{
    public abstract class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Role Role { get; set; }
        public string InstagramLink { get; set; }
        public string FacebookLink { get; set; }
        public string PhotoPath { get; set; }
        public string Description { get; set; }
    }
}