using contactUs.web.Areas.Admin.ViewModels;
using contactUs.web.ViewModels;

namespace contactUs.web.Services.Interface;

public interface IContactUsService
{
    bool creatlostco(FormContactUsViewModel frco);

    List<ListContactusViewModel> list();
    
    bool registerUser(RegisterViewModel register);

    List<ListUserViewModel> ListUser();

    UpdateUserViewModel getuserbyid(int id);

    bool updateuserr(ListUserViewModel listuu);

}