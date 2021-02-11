using System;
using blogMe.Data.Models.Entries;

namespace blogMe.Data.Models.Hashtags
{
    public class EntryHashtag
    {
        public Guid Id { get; set; }
        public Entry Entry { get; set; }
        public Hashtag Hashtag { get; set; }
    }
}