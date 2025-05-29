using ContactUs.dal.Entities.User;

namespace ContactUs.dal.Repository.Interface;

public interface IUserRepository
{
    bool getUserbyEmail(string Email);

    List<User> ListUser();

    User getUserById(int Id);

    void update(User user );

    void add( User user);
    void save();
}