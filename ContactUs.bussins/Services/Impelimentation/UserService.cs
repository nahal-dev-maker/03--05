using ContactUs.bussins.Services.Interface;
using ContactUs.dal.Entities.User;
using ContactUs.dal.Repository.Interface;
using ContactUs.dal.ViewModels;

namespace ContactUs.bussins.Services.Impelimentation;

public class UserService:IUserService
{
    #region ctotr

    private IUserRepository _userRepository;
    private IContactUsRepository _iContactUsRepository;

    public UserService(IContactUsRepository iContactUsRepository, IUserRepository userRepository)
    {
        _iContactUsRepository = iContactUsRepository;
        _userRepository = userRepository;
    }

    #endregion
   
    public bool updateuserr(ListUserViewModel listuu)
    {
        var user= _userRepository.getUserById(listuu.Id);
        if (user == null) return false;
        else
        {
            user.Email = listuu.Email;
            user.Firstname = listuu.Firstname;
            user.Lastname = listuu.Lastname;
            user.password = listuu.password;
            user.mobile = listuu.mobile;
            user.registerDatetime = listuu.registerDatetime;

        }
        _userRepository.update(user);
        _userRepository.save();
        return true;
    } 
    
    
    public UpdateUserViewModel getuserbyid(int id)
    {

        var user=  _userRepository.getUserById(id);
        var user1 = new UpdateUserViewModel();
        user1.Email = user.Email;
        user1.password = user.password;
        user1.mobile = user.mobile;
        user1.Firstname = user.Firstname;
        user1.Lastname = user.Lastname;
        user.registerDatetime = user.registerDatetime;
        user1.Id = user.Id;
        return user1;
    }
    
    
 
    
    
    public bool registerUser(RegisterViewModel register)
    {
        var usserr= _userRepository.getUserbyEmail(register.Email);

        if (usserr) return false; 
     
        var user1 = new User()
        {
            Email = register.Email,
            Firstname = register.Firstname,
            Lastname = register.Lastname,
            mobile = register.mobile,
            password = register.password,
            
        };

        _userRepository.add(user1);
        _userRepository.save(); 
       

        return true;

    }
    
    
    
    
    
    public List<ListUserViewModel> ListUser()
    {
        return  _userRepository.ListUser().Select(u => new ListUserViewModel()
        {
            Email = u.Email,
            Id = u.Id,
            password = u.password,
            Firstname = u.Firstname,
            Lastname = u.Lastname,
            mobile = u.mobile,
            registerDatetime = u.registerDatetime,
        }).ToList();
    }
}