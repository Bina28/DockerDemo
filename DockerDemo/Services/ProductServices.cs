
using DockerDemo.Data;
using DockerDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace DockerDemo.Services;

public class ProductServices
{
    private readonly  AppDbContext _context;

        public ProductServices(AppDbContext context)
        {
            _context = context;
    }

    public async Task<Product> AddProduct(Product product)
    {
     var productDb = new Product
     {
        Id = Guid.NewGuid().ToString(),
        Name = product.Name
     };
        _context.Products.Add(productDb);
        await _context.SaveChangesAsync();
        return productDb;

    }

    public async Task<List<Product>>  GetProducts()
    {
       var products =await  _context.Products.ToListAsync();
         return products;
    }
}