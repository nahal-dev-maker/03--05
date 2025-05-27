using contactUs.web.Services.Interface;
using contactUs.web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace contactUs.web.Controllers;

public class AccountController : Controller
{
    #region Ctor

    private IContactUsService _contactUsService;

    public AccountController(IContactUsService contactUsService)
    {
        _contactUsService = contactUsService;
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
    _contactUsService.registerUser(reg);
    return RedirectToAction("index", "Home");
        return View();
    }
    

    #endregion
    
}