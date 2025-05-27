using contactUs.web.Context;
using contactUs.web.Entities.User;
using contactUs.web.Repository.Interface;
using Microsoft.AspNetCore.Http.HttpResults;

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

    public void add(User user)
    {
        _db.userss.Add(user);
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

    public bool getUserbyEmail(string Email)
    {
     return  _db.userss.Any(u => u.Email == Email);
    }

    public List<User> ListUser()
    {
       return _db.userss.ToList();
    }

    public User getUserById(int Id)
    {
     return   _db.userss.SingleOrDefault(u => u.Id == Id);
    }

    public void update(User user)
    {
        
        _db.userss.Update(user);
    }
}