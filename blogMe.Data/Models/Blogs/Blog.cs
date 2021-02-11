using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using blogMe.Data.Models.Users;

namespace blogMe.Data.Models.Blogs
{
    public class Blog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(TypeName = "VARCHAR(30)")]
        public Guid Id { get; set; }
        [Required, StringLength(255)]
        public string Name { get; set; }
        [Column(TypeName = "VARCHAR(30)")]
        public User Owner { get; set; }
    }
}