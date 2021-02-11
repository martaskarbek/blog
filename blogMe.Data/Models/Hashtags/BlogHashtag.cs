using System;
using blogMe.Data.Models.Blogs;

namespace blogMe.Data.Models.Hashtags
{
    public class BlogHashtag
    {
        public Guid Id { get; set; }
        public Blog Blog { get; set; }
        public Hashtag Hashtag { get; set; }
    }
}