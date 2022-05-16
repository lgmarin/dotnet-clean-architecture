using AutoMapper;
using mvcCleanArch.Application.Interfaces;
using mvcCleanArch.Application.ViewModels;
using mvcCleanArch.Domain.Entities;
using mvcCleanArch.Domain.Interfaces;

namespace mvcCleanArch.Application.Services;

public class ProductService: IProductService
{
    private IProductRepository _productRepository;
    private readonly IMapper _mapper;

    //Dependency Injection in the Constructor
    public ProductService(IMapper mapper, IProductRepository productRepository)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<ProductViewModel>> GetProducts()
    {
        var result = await _productRepository.GetProducts();
        return _mapper.Map<IEnumerable<ProductViewModel>>(result);
    }

    public async Task<ProductViewModel> GetById(int? id)
    {
        var result = await _productRepository.GetById(id);
        return _mapper.Map<ProductViewModel>(result);
    }

    public void Add(ProductViewModel product)
    {
        var mapProduct = _mapper.Map<Product>(product);
        _productRepository.Add(mapProduct);
    }

    public void Update(ProductViewModel product)
    {
        var mapProduct = _mapper.Map<Product>(product);
        _productRepository.Update(mapProduct);
    }

    public void Remove(int? id)
    {
        var product = _productRepository.GetById(id).Result;
        _productRepository.Remove(product);
    }
}