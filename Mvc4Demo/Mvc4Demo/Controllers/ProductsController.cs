using Microsoft.AspNetCore.Mvc;

public class ProductsController : Controller
{
    public IActionResult Index()
    {
        var products = new List<Product>()
        {
            new Product { ID = 1, Name = "Product 1", Price = 100.50m, CreatedDate = DateTime.Now },
            new Product { ID = 2, Name = "Product 2", Price = 200.75m, CreatedDate = DateTime.Now },
            new Product { ID = 3, Name = "Product 3", Price = 300.00m, CreatedDate = DateTime.Now }
        };

        return View(products);
    }
}
