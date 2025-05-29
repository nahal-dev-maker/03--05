using ContactUs.bussins.Services.Interface;
using ContactUs.dal.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace contactUs.web.Areas.Admin.Controllers;

public class HomeController : AdminBaseController
{
    #region ctor

    private IContactUsService _contactUsService;

    private IUserService _userService;
    public HomeController(IContactUsService contactUsService, IUserService userService)
    {
        _contactUsService = contactUsService;
        _userService = userService;
    }

    #endregion
    
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
        var user=_userService.ListUser();
        return View(user);
    }

 

    #endregion


    #region UpdateUser

    [HttpGet]
    public IActionResult UpdateUser(int Id)
    {
       var user= _userService.getuserbyid(Id);
        return View(user);
    }

    [HttpPost]
    public IActionResult UpdateUser(ListUserViewModel listu)
    {
       var user= _userService.updateuserr(listu);
       return RedirectToAction("ListUser");
        return View();
    }

    #endregion
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
}