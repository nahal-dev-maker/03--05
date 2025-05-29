using ContactUs.dal.Entities.ListContactUs;
using ContactUs.dal.Entities.User;

namespace ContactUs.dal.Repository.Interface;

public interface IContactUsRepository
{
    void add(ListContactUs listco);
   

    List<ListContactUs> list();



}