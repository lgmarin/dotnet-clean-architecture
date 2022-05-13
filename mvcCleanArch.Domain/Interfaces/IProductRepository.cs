using mvcCleanArch.Domain.Entities;

namespace mvcCleanArch.Domain.Interfaces;

public interface IProductRepository
{
    IEnumerable<Product> GetProducts();
}