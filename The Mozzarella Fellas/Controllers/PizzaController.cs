using System.Linq;
using System.Web.Mvc;
using The_Mozzarella_Fellas.Models;

namespace The_Mozzarella_Fellas.Controllers
{

    public class PizzaController : Controller
    {
        ApplicationDbContext dbs = new ApplicationDbContext();
        // GET: Pizza
        public ActionResult Index()
        {
            var pizzalist = (from p in dbs.Pizzas select p).ToList();
            return View(pizzalist);
        }
    }
}