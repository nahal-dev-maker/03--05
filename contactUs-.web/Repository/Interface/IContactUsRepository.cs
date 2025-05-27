using contactUs.web.Context;
using contactUs.web.Entities.User;

namespace contactUs.web.Repository.Interface;

public interface IContactUsRepository
{
    void add(ListContactUs listco);
    void add( User user);
    void save();

    List<ListContactUs> list();

    bool getUserbyEmail(string Email);
    
    
    
    
}