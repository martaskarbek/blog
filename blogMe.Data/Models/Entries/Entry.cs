using System;
using blogMe.Data.Models.Blogs;
using blogMe.Data.Models.Users;

namespace blogMe.Data.Models.Entries
{
    public class Entry
    {
        public Guid Id { get; set; }
        public DateTime PublicationDate { get; set; }
        public string PhotoPath { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public User Author { get; set; }
        public Blog Blog { get; set; }
    }
}