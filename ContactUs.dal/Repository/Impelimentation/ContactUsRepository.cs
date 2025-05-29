using ContactUs.dal.Context;
using ContactUs.dal.Entities.ListContactUs;
using ContactUs.dal.Entities.User;
using ContactUs.dal.Repository.Interface;

namespace ContactUs.dal.Repository.Impelimentation;

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

  

    public List<ListContactUs> list()
    {
       var user= _db.Contact.ToList();
       return user;

    }

}