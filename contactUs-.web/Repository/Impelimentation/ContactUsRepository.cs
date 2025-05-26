using contactUs.web.Context;
using contactUs.web.Entities.User;
using contactUs.web.Repository.Interface;

namespace contactUs.web.Repository.Impelimentation;

public class ContactUsRepository:IContactUsRepository
{
    private ApplicationDbContext _db;

    public ContactUsRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public void add(ListContactUs listco)
    {
        _db.Contact.Add(listco);
    }

    public void save()
    {
        _db.SaveChanges();
    }

    public List<ListContactUs> list()
    {
       var user= _db.Contact.ToList();
       return user;

    }
}