using System;
using Backend_Boilerplate.DTOs;
using Backend_Boilerplate.Models;

namespace Backend_Boilerplate.Services;

public interface IProductService
{
    IEnumerable<Product> GetAllProducts();
    Product CreateProduct(CreateProductRequest request);
    bool DeleteProduct(int id);
}
