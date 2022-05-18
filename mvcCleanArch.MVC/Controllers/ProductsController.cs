using Microsoft.AspNetCore.Mvc;
using mvcCleanArch.Application.Interfaces;

namespace mvcCleanArch.MVC.Controllers;

public class ProductsController : Controller
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var result = await _productService.GetProducts();
        return View(result);
    }
}