using Microsoft.AspNetCore.Mvc;
using WishList.Data;
using WishList.Models;

namespace WishList.Controllers
{
    public class ItemController : Controller
    {
        private ApplicationDbContext _context;
        public ItemController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Items;
            return View("Index", data);
        }

        [HttpGet]
        public IActionResult Create()
        { 
            return View("Create");
        }


        [HttpPost]
        public IActionResult Create(Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();
            return RedirectToAction("Index");  
        }

        public IActionResult Delete(int Id)
        {
            var item = _context.Items.Find(Id);
            if (item != null)
            { 
                _context.Items.Remove(item);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
