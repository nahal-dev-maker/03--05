using contactUs.web.Areas.Admin.ViewModels;
using contactUs.web.Entities.User;
using contactUs.web.Repository.Impelimentation;
using contactUs.web.Repository.Interface;
using contactUs.web.Services.Interface;
using contactUs.web.ViewModels;
using Microsoft.AspNetCore.Http.HttpResults;

namespace contactUs.web.Services.Impelimentation;

public class ContactUsService:IContactUsService
{
    private IContactUsRepository _iContactUsRepository;

    public ContactUsService(IContactUsRepository iContactUsRepository)
    {
        _iContactUsRepository = iContactUsRepository;
    }

    public bool creatlostco(FormContactUsViewModel frco)
    {
        var user = new ListContactUs()
        {
            Email = frco.Email,
            firstName = frco.firstName,
            LastName = frco.LastName,
            Mobile = frco.Mobile,
            Title = frco.Title,
            Description = frco.Description
        };

        _iContactUsRepository.add(user);
        _iContactUsRepository.save();
        return true;
        
    }

    public List<ListContactusViewModel> list()
    {
    
        return _iContactUsRepository.list().Select(u => new ListContactusViewModel()
        {
            Id = u.Id,
            Email = u.Email,
            firstName = u.firstName,
            LastName = u.LastName,
            Mobile = u.Mobile,
            Title = u.Title,
            Description = u.Description,
            submitDateTime = u.submitDateTime
        }).ToList();
        
        
    }

   
    
    
    public bool registerUser(RegisterViewModel register)
    {
       var usserr= _iContactUsRepository.getUserbyEmail(register.Email);

       if (usserr) return false; 
     
           var user1 = new User()
           {
               Email = register.Email,
               Firstname = register.Firstname,
               Lastname = register.Lastname,
               mobile = register.mobile,
               password = register.password,
            
           };

           _iContactUsRepository.add(user1);
           _iContactUsRepository.save(); 
       

       return true;

    }

    public List<ListUserViewModel> ListUser()
    {
      return  _iContactUsRepository.ListUser().Select(u => new ListUserViewModel()
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

    public UpdateUserViewModel getuserbyid(int id)
    {

      var user=  _iContactUsRepository.getUserById(id);
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

    public bool updateuserr(ListUserViewModel listuu)
    {
       var user= _iContactUsRepository.getUserById(listuu.Id);
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
       _iContactUsRepository.update(user);
       _iContactUsRepository.save();
       return true;
    }
}