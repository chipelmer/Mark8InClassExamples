using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

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

        public IActionResult Delete(int id)
        {
            ProductRepository repo = new ProductRepository();
            repo.DeleteProductFromDatabase(id);
            return RedirectToAction("Index", "Product");
        }
    }
}