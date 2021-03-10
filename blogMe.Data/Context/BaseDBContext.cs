using blogMe.Data.Models.Blogs;
using blogMe.Data.Models.Comments;
using blogMe.Data.Models.Entries;
using blogMe.Data.Models.Hashtags;
using blogMe.Data.Models.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace blogMe.Data.Context
{
    public class BaseDBContext : IdentityDbContext<IdentityUser>
    {
        private readonly string _connectionString;

        public BaseDBContext(DbContextOptions<BaseDBContext> options)
            : base(options)
        {
        }
        
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Entry> Entries { get; set; }
        public DbSet<Hashtag> Hashtags { get; set; }
        public DbSet<EntryHashtag> EntryHashtags { get; set; }
        public DbSet<BlogHashtag> BlogHashtags { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
    }
}