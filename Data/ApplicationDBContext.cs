using Microsoft.EntityFrameworkCore;
using CRUDWebApplication.Models;

namespace CRUDWebApplication.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
        : base(options)
        { }

        public DbSet<Category> Categories
        {
            get;set;
        }
    }
}
