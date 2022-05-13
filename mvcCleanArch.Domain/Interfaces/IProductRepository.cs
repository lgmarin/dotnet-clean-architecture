using mvcCleanArch.Domain.Entities;

namespace mvcCleanArch.Domain.Interfaces;

interface IProductRepository
{
    IEnumerable<Product> GetProducts();
}