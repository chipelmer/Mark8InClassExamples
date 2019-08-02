using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Mark8InClassExamplesAspNet.Models;

namespace Mark8InClassExamplesAspNet.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            ProductRepository repo = new ProductRepository();
            List<Product> allProducts = repo.GetAllProducts();

            return View(allProducts);
        }

        public IActionResult ViewProduct(int id)
        {
            ProductRepository repo = new ProductRepository();
            Product prod = repo.GetProduct(id);

            if (prod == null)
            {
                return View("ProductNotFound");
            }

            return View("Product", prod);
        }

        public IActionResult NewProduct()
        {
            return View();
        }

        public IActionResult Add(Product prod)
        {
            ProductRepository repo = new ProductRepository();
            repo.AddProductToDatabase(prod);
            return RedirectToAction("Index", "Product");
        }

        public IActionResult UpdateProduct(int id)
        {
            ProductRepository repo = new ProductRepository();
            Product prod = repo.GetProduct(id);
            return View(prod);
        }

        public IActionResult Update(Product prod)
        {
            ProductRepository repo = new ProductRepository();
            repo.UpdateProduct(prod);
            return RedirectToAction("ViewProduct", "Product", new { id = prod.Id });
        }

        public IActionResult Delete(int id)
        {
            ProductRepository repo = new ProductRepository();
            repo.DeleteProductFromDatabase(id);
            return RedirectToAction("Index", "Product");
        }
    }
}