using ContactUs.dal.Context;
using ContactUs.dal.Entities.User;
using ContactUs.dal.Repository.Interface;

namespace ContactUs.dal.Repository.Impelimentation;

public class UserRepository:IUserRepository
{

    private ApplicationDbContext _dbcontext;

    public UserRepository(ApplicationDbContext dbcontext)
    {
        _dbcontext = dbcontext;
    }

    public bool getUserbyEmail(string Email)
    {
        return  _dbcontext.userss.Any(u => u.Email == Email);
    }

    public List<User> ListUser()
    {
        return _dbcontext.userss.ToList();
    }

    public User getUserById(int Id)
    {
        return   _dbcontext.userss.SingleOrDefault(u => u.Id == Id);
    }

    public void update(User user)
    {
        
        _dbcontext.userss.Update(user);
    }
    
    public void add(User user)
    {
        _dbcontext.userss.Add(user);
    }

    public void save()
    {
        _dbcontext.SaveChanges();
    }
}