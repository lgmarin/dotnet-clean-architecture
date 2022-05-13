using mvcCleanArch.Domain.Interfaces;
using mvcCleanArch.Domain.Entities;
using mvcCleanArch.Infra.Data.Context;

namespace mvcCleanArch.Infra.Data.Repositories;

public class ProductRepository : IProductRepository
{
    private ApplicationDbContext _context;

    public ProductRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Product> GetProducts()
    {
        return _context.Products;
    }
}