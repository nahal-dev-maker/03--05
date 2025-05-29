using ContactUs.dal.ViewModels;

namespace ContactUs.bussins.Services.Interface;

public interface IContactUsService
{
    bool creatlostco(FormContactUsViewModel frco);

   List<ListContactusViewModel> list();
    


}