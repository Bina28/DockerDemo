using DockerDemo.Models;
using DockerDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace DockerDemo.Controllers;


[ApiController]
[Route("[controller]")]
public class ProductController: ControllerBase
{

    private readonly ProductServices _productServices;

    public ProductController(ProductServices productServices)
    {
        _productServices = productServices;
    }

    [HttpGet]
    public async Task<ActionResult<List<Product>>> Get()
    {
        var products = await _productServices.GetProducts();
        return Ok(products);
    }

    [HttpPost]
    public async Task<ActionResult<Product>> AddProduct(Product product)
    {
        var addedProduct = await _productServices.AddProduct(product);
        return Ok(addedProduct);
    }
    }
