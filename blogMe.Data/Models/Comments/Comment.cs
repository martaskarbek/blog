using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using blogMe.Data.Models.Entries;

namespace blogMe.Data.Models.Comments
{
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(TypeName = "VARCHAR(30)")]
        public Guid Id { get; set; }
        [Column(TypeName = "VARCHAR(30)")]
        public Entry Entry { get; set; }
        [Required, StringLength(5000)]
        public string Content { get; set; }
        public string CommenterName { get; set; }
        public DateTime CommentDate { get; set; }
    }
}