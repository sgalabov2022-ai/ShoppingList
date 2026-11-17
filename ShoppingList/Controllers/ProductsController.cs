using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingList.Data;
using ShoppingList.Models.Products;
using ShoppingList.Data.Entitites;

namespace ShoppingList.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext data;
        public ProductsController(ApplicationDbContext data)
        {
            this.data = data;
        }
        // GET: ProductsController
        public ActionResult Index()
        {
            var products = data.Products
                .Select(x => new ProductListVM()
                {
                    Id = x.Id,
                    ProductName = x.ProductName,
                }).ToList();
            return View(products);
        }

        // GET: ProductsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductCreateVM model)
        {
            var product = new Product()
            {
                ProductName = model.ProductName
            };
            this.data.Products.Add(product);
            data.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: ProductsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
