using contactUs.web.Areas.Admin.ViewModels;
using contactUs.web.Context;
using contactUs.web.Entities.User;
using contactUs.web.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace contactUs.web.Areas.Controllers;

public class HomeController : AdminBaseController
{
    private IContactUsService _contactUsService;

    public HomeController(IContactUsService contactUsService)
    {
        _contactUsService = contactUsService;
    }


    public IActionResult Index()
    {
        return View();
    }

    #region List
    [HttpGet]
    public IActionResult listContactUs()
    {

        var lisst=_contactUsService.list();
        return View(lisst);
    }
    
  

    #endregion






    #region LIstUser

    [HttpGet]
    public IActionResult ListUser()
    {
        var user=_contactUsService.ListUser();
        return View(user);
    }

 

    #endregion


    #region UpdateUser

    [HttpGet]
    public IActionResult UpdateUser(int Id)
    {
       var user= _contactUsService.getuserbyid(Id);
        return View(user);
    }

    [HttpPost]
    public IActionResult UpdateUser(ListUserViewModel listu)
    {
       var user= _contactUsService.updateuserr(listu);
       return RedirectToAction("ListUser");
        return View();
    }

    #endregion
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
}