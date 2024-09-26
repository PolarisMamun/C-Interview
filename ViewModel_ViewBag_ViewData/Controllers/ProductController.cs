using Microsoft.AspNetCore.Mvc;
using ViewModel_ViewBag_ViewData.Models;

namespace ViewModel_ViewBag_ViewData.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            List<Product> products = new List<Product> 
            { 
                new Product{ Id = 1,Name="Product 1",Price = 10.99m},
                new Product{ Id = 2,Name="Product 2",Price = 19.99m},
                new Product{ Id = 3,Name="Product 3",Price = 29.99m},
                new Product{ Id = 4,Name="Product 4",Price = 39.99m}
            };

            var viewModel = new ProductViewModel { Products = products };
            return View(viewModel);
        }
    }
}
