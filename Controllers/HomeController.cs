using System.Collections.Generic;
using System.Web.Mvc;
using lab2.Models;

namespace lab2.Controllers
{
    public class HomeController : Controller
    {
        public dynamic Food { get; private set; }
        public dynamic Tech { get; private set; }
        public dynamic Sports { get; private set; }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    

        public ActionResult CategoriesController()
        {
            {
                var CategoriesController = new List<CategoriesController>();
                CategoriesController.Add(Food);
                CategoriesController.Add(Tech);
                CategoriesController.Add(Sports);



            }
            
                ViewBag.Food = Food;
                ViewBag.Tech = Tech;
                ViewBag.Sports = Sports;
            
    
            return View();
        }
        public ActionResult ViewCategoriesController()
        {
            return View();
        }

    }
}



