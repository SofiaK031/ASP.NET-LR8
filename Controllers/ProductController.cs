using LR8.Models;
using Microsoft.AspNetCore.Mvc;

namespace LR8.Controllers
{
    public class ProductController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }

        private List<ProductModel> GetProducts()
        {
            var products = new List<ProductModel>();
            products.Add(new ProductModel { Id = 1, Type = "Pizza", Name = "Four cheese", Price = 11.49, CreatedDate = DateTime.Now });
            products.Add(new ProductModel { Id = 2, Type = "Pizza", Name = "Pepperoni", Price = 10.99, CreatedDate = DateTime.Now });
            products.Add(new ProductModel { Id = 3, Type = "Pizza", Name = "Buffalo chicken", Price = 12.99, CreatedDate = DateTime.Now });
            products.Add(new ProductModel { Id = 4, Type = "Appetiser", Name = "Mozzarella sticks", Price = 5.99, CreatedDate = DateTime.Now });
            products.Add(new ProductModel { Id = 5, Type = "Appetiser", Name = "Pasta carbonara", Price = 10.99, CreatedDate = DateTime.Now });
            products.Add(new ProductModel { Id = 6, Type = "Appetiser", Name = "Caesar salad", Price = 6.49, CreatedDate = DateTime.Now });
            products.Add(new ProductModel { Id = 7, Type = "Beverage", Name = "Mineral water", Price = 1.49, CreatedDate = DateTime.Now });
            products.Add(new ProductModel { Id = 8, Type = "Beverage", Name = "Orange juice", Price = 2.49, CreatedDate = DateTime.Now });
			products.Add(new ProductModel { Id = 9, Type = "Beverage", Name = "Iced tea", Price = 2.19, CreatedDate = DateTime.Now });

			return products;
        }

        public IActionResult ProductsAsList()
        {
            var products = GetProducts();
            return View(products);
        }

        public IActionResult ProductsAsTable()
        {
            var products = GetProducts();
            return View(products);
        }
    }
}
