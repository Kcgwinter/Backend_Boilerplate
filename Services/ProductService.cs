using Backend_Boilerplate.DTOs;
using Backend_Boilerplate.Models;

namespace Backend_Boilerplate.Services;

public class ProductService : IProductService
{
    private readonly AppDbContext _context;

    public ProductService(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Product> GetAllProducts()
    {
        var products = _context.Products.ToList();
        return products;
    }

    public Product GetProductById(int id)
    {
        var product = _context.Products.Find(id);
        return product;
    }

    public Product CreateProduct(CreateProductRequest request)
    {
        var newProduct = new Product
        {
            Name = request.Name,
            Description = request.Description
        };

        _context.Products.Add(newProduct);
        _context.SaveChanges();
        return newProduct;
    }

    public bool DeleteProduct(int id)
    {
        var product = _context.Products.FirstOrDefault(e => e.Id == id);
        if (product == null)
        {
            return false;
        }
        _context.Products.Remove(product);
        _context.SaveChanges();

        return true;
    }
}
