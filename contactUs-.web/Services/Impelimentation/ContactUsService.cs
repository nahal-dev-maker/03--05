using contactUs.web.Areas.Admin.ViewModels;
using contactUs.web.Entities.User;
using contactUs.web.Repository.Impelimentation;
using contactUs.web.Repository.Interface;
using contactUs.web.Services.Interface;
using contactUs.web.ViewModels;

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
}