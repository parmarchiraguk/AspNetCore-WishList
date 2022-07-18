using Microsoft.EntityFrameworkCore;
using WishList.Models;

namespace WishList.Data
{
    public class ApplicationDbContext: DbContext
    {
        private readonly DbContextOptions dbContextOptions;

        public DbSet<Item> Items { get; set; }

        public ApplicationDbContext(DbContextOptions dbContextOptions)
        {
            this.dbContextOptions = dbContextOptions;
        }
    }
}
