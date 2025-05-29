using ContactUs.dal.ViewModels;

namespace ContactUs.bussins.Services.Interface;

public interface IUserService
{
    bool registerUser(RegisterViewModel register);


    UpdateUserViewModel getuserbyid(int id);

    bool updateuserr(ListUserViewModel listuu);
    
    List<ListUserViewModel> ListUser();

}