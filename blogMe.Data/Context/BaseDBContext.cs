using Microsoft.EntityFrameworkCore;

namespace blogMe.Data.Context
{
    public class BaseDBContext : DbContext
    {
        private readonly string _connectionString;

        public BaseDBContext(DbContextOptions<BaseDBContext> options)
            : base(options)
        {
        }
    }
}