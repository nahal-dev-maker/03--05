using ContactUs.bussins.Services.Interface;
using ContactUs.dal.Entities.ListContactUs;
using ContactUs.dal.Entities.User;
using ContactUs.dal.Repository.Interface;
using ContactUs.dal.ViewModels;

namespace ContactUs.bussins.Services.Impelimentation;

public class ContactUsService:IContactUsService
{
    private IContactUsRepository _iContactUsRepository;

    private IUserRepository _userRepository;
    public ContactUsService(IContactUsRepository iContactUsRepository, IUserRepository userRepository)
    {
        _iContactUsRepository = iContactUsRepository;
        _userRepository = userRepository;
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
        _userRepository.save();
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









 
}