using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blogMe.Data.Models.Users
{
    public class User : IdentityUser
    {
        /*[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(TypeName = "VARCHAR(30)")]
        public Guid Id { get; set; }*/
     /*   [Column(TypeName = "VARCHAR(50)")]
        [Required, StringLength(50)]
        public string Name { get; set; }*/
        [Column(TypeName = "VARCHAR(70)")]
        [Required, StringLength(70)]
        public string Password { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        [Required, StringLength(50)]
        /*public string Email { get; set; }*/
        public Role Role { get; set; }
        [Column(TypeName = "VARCHAR(200)")]
        public string InstagramLink { get; set; }
        [Column(TypeName = "VARCHAR(200)")]
        public string FacebookLink { get; set; }
        [Column(TypeName = "VARCHAR(300)")]
        public string PhotoPath { get; set; }
        public string Description { get; set; }
    }
}