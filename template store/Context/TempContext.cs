using Microsoft.EntityFrameworkCore;
using template_store.Models;

namespace template_store.Context
{
    public class TempContext:DbContext
    {
        public TempContext(DbContextOptions<TempContext> options) : base(options)
        {

        }
        public DbSet<Templates> Templates { get; set; }

    }
}
