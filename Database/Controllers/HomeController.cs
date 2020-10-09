using System.Web.Mvc;

namespace Database.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DatabaseContextDataContext db = new DatabaseContextDataContext();
            db.Users.InsertOnSubmit(new Database.User
            {
                Name = "Route",
                Surname = "Index",
                Phone = 000999888,
                Country = "Controller"
            });
            db.SubmitChanges();
            return View();
        }

        public ActionResult About()
        {
            DatabaseContextDataContext db = new DatabaseContextDataContext();

            db.Users.InsertOnSubmit(new Database.User
            {
                Name = "Route",
                Surname = "About",
                Phone = 777888999,
                Country = "Controller"
            });
            db.SubmitChanges();

            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            DatabaseContextDataContext db = new DatabaseContextDataContext();

            db.Users.InsertOnSubmit(new Database.User
            {
                Name = "Route",
                Surname = "Contact",
                Phone = 666555888,
                Country = "Controller"
            });
            db.SubmitChanges();

            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}