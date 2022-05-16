using mvcCleanArch.Domain.Interfaces;
using mvcCleanArch.Domain.Entities;
using mvcCleanArch.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace mvcCleanArch.Infra.Data.Repositories;

public class ProductRepository : IProductRepository
{
    private ApplicationDbContext _context;

    public ProductRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Product>> GetProducts()
    {
        return await _context.Products.ToListAsync();
    }

    public async Task<Product> GetById(int? id)
    {
        return await _context.Products.FindAsync(id);
    }

    void Add(Product product)
    {
        
    }
    void Update(Product product)
    {

    }
    void Remove(Product product)
    {

    }
}