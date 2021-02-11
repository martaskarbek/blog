using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using blogMe.Data.Models.Blogs;
using blogMe.Data.Models.Users;

namespace blogMe.Data.Models.Entries
{
    public class Entry
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(TypeName = "VARCHAR(30)")]
        public Guid Id { get; set; }
        public DateTime PublicationDate { get; set; }
        public string PhotoPath { get; set; }
        [Required, StringLength(300)]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        [Column(TypeName = "VARCHAR(30)")]
        public User Author { get; set; }
        [Column(TypeName = "VARCHAR(30)")]
        public Blog Blog { get; set; }
    }
}