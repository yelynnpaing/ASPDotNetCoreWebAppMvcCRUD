using ASPDotNetCoreWebAppMvcCRUD.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASPDotNetCoreWebAppMvcCRUD.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext context;
        public ProductController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var products = context.Products.OrderByDescending(p => p.Id).ToList();
            return View(products);
        }
    }
}
