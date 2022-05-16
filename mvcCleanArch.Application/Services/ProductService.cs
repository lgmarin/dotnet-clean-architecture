using mvcCleanArch.Application.Interfaces;
using mvcCleanArch.Application.ViewModels;

namespace mvcCleanArch.Application.Services;

public class ProductService: IProductService
{
    public Task<IEnumerable<ProductViewModel>> GetProducts()
    {
        throw new NotImplementedException();  
    }

    public Task<ProductViewModel> GetById(int? id)
    {
        throw new NotImplementedException();  
    }

    public void Add(ProductViewModel product)
    {
        throw new NotImplementedException();
    }

    public void Update(ProductViewModel product)
    {
        throw new NotImplementedException();
    }

    public void Remove(int? id)
    {
        throw new NotImplementedException();
    }
}