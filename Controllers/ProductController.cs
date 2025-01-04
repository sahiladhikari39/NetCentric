using hamroStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace hamroStore.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            //select * from products
            var products = _context.Products.ToList();//get the list of products from the database
            return View(products);
        }
    }
}
