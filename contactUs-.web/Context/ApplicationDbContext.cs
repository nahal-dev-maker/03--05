using contactUs.web.Entities.User;
using Microsoft.EntityFrameworkCore;

namespace contactUs.web.Context;

public class ApplicationDbContext:DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
    {

    }


    public DbSet<ListContactUs> Contact { get; set; }
}