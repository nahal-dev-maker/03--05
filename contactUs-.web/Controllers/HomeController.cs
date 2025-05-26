using System.Diagnostics;
using contactUs.web.Services.Impelimentation;
using contactUs.web.Services.Interface;
using contactUs.web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace contactUs.web.Controllers;

public class HomeController : Controller
{

    #region Ctor


    private IContactUsService _iContactUsService;

    public HomeController(IContactUsService iContactUsService)
    {
        _iContactUsService = iContactUsService;
    }

    #endregion
   

    public IActionResult Index()
    {
        return View();
    }

    #region creat

    [HttpGet]
    public IActionResult contactUs()
    {
        return View();
    }

    [HttpPost]
    public IActionResult contactUs(FormContactUsViewModel contactUs)
    {
       var useradd= _iContactUsService.creatlostco(contactUs);
       return RedirectToAction("index");
        return View();
    }

    #endregion

   


}