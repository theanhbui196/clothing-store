using ClothingStore.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ClothingStore.Controllers
{
    public class HomeController : Controller
    {
        private ICommandDispatcher _commandDispatcher;
        private IQueryDispatcher _queryDispatcher;
        public HomeController(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher)
        {
            _commandDispatcher = commandDispatcher;
            _queryDispatcher = queryDispatcher;
        }

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

        public async Task<ActionResult> Product()
        {
            ViewBag.Message = "Product here";
            var result = await _queryDispatcher.DispatchAsync(new GetAllProductQuery
            {
                IsDeleted = false
            });

            // Need to parse to data object here
            return View(result);
        }
    }
}