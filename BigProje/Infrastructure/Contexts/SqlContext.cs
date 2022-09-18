using BigProje.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BigProje.Infrastructure.Contexts
{
    public class SqlContext : IdentityDbContext<AppUser>
    {

        public SqlContext()
        {

        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {

        }

    }
}
