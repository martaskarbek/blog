using System;
using blogMe.Data.Models.Entries;

namespace blogMe.Data.Models.Comments
{
    public class Comment
    {
        public Guid Id { get; set; }
        public Entry Entry { get; set; }
        public string Content { get; set; }
        public string CommenterName { get; set; }
        public DateTime CommentDate { get; set; }
    }
}