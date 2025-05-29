using Microsoft.AspNetCore.Mvc;

namespace contactUs.web.Areas.Admin.Controllers;

[Area("Admin")]

public class AdminBaseController : Controller
{
    public IActionResult Index()
    {
        return View();
    }


   
}