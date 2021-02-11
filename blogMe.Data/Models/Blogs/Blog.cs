using System;
using System.ComponentModel.DataAnnotations;
using blogMe.Data.Models.Users;

namespace blogMe.Data.Models.Blogs
{
    public class Blog
    {
        public Guid Id { get; set; }
        [Required, StringLength(255)]
        public string Name { get; set; }
        public User Owner { get; set; }
    }
}