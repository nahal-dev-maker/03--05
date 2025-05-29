using ContactUs.bussins.Services.Interface;
using ContactUs.dal.Repository.Interface;
using ContactUs.dal.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace contactUs.web.Controllers;

public class AccountController : Controller
{
    #region Ctor


    private IUserService _userService;
    public AccountController(IContactUsService contactUsService,  IUserService userService)
    {
        _userService = userService;
    }
    

    #endregion


    #region creat
    
    [HttpGet]
    public IActionResult register()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult register(RegisterViewModel reg)
    {
    _userService.registerUser(reg);
    return RedirectToAction("index", "Home");
        return View();
    }
    

    #endregion
    
}