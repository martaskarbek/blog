using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using blogMe.Data.Models.Blogs;

namespace blogMe.Data.Models.Hashtags
{
    public class BlogHashtag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(TypeName = "VARCHAR(30)")]
        public Guid Id { get; set; }
        [Column(TypeName = "VARCHAR(30)")]
        public Blog Blog { get; set; }
        [Column(TypeName = "VARCHAR(30)")]
        public Hashtag Hashtag { get; set; }
    }
}