using Microsoft.AspNetCore.Mvc;
using mvcCleanArch.Application.Interfaces;
using mvcCleanArch.Application.ViewModels;

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

    [HttpGet()]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create([Bind("Id, Name, Description, Price")] ProductViewModel product)
    {
        if (ModelState.IsValid)
        {
            _productService.Add(product);
            return RedirectToAction(nameof(Index));
        }
        return View(product);
    }

    [HttpGet()]
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null) return NotFound();

        var product = await _productService.GetById(id);

        if (product == null) return NotFound();

        return View(product);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit([Bind("Id, Name, Description, Price")] ProductViewModel product)
    {
        if (ModelState.IsValid)
        {
            try
            {
                _productService.Update(product);
            }
            catch (System.Exception)
            {
                
                throw;
            }
            return RedirectToAction(nameof(Index));
        }
        return View(product);
    }

    [HttpGet()]
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null) return NotFound();

        var product = await _productService.GetById(id);

        if (product == null) return NotFound();

        return View(product);
    }
}