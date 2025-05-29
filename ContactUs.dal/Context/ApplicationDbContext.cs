using ContactUs.dal.Entities.ListContactUs;
using ContactUs.dal.Entities.User;
using Microsoft.EntityFrameworkCore;

namespace ContactUs.dal.Context;

public class ApplicationDbContext:DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
    {

    }


    public DbSet<ListContactUs> Contact { get; set; }
    public DbSet<User> userss { get; set; }
}