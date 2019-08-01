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
    }
}