using Microsoft.AspNetCore.Mvc;

namespace mvcCleanArch.MVC.Controllers;

public class ProductsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}