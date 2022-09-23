using BigOn.WebUI.Models.DataContents;
using BigOn.WebUI.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BigOn.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly BigOnDbContext db;

        public HomeController(BigOnDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ContactUs(ContactPost model)
        {
            if (ModelState.IsValid)
            {
                db.ContactPosts.Add(model);
                db.SaveChanges();
                //ViewBag.Message = "Muracietiniz qeyde alindi, tezlikle geri donush edeceyik.";

                //ModelState.Clear();
                //return View();

                var response = new {
                    error = false,
                    message = "Muracietiniz qeyde alindi, tezlikle geri donush edeceyik.",
                    
                };
                return Json(response);
            }
            var errorResponse = new
            {
                error = true,
                message = "Muracietiniz qeyde alinmadi, daxil edilenler yanlishdir",
                state = ModelState
        };
                return Json(errorResponse);
    }

        public IActionResult Faq()
        {
            var data = db.Faqs.Where(f => f.DeletedDate == null).ToList();
            return View(data);
        }
    }
}
