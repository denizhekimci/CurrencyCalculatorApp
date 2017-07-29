using System.Web.Mvc;
using CurrencyCalculatorApp.Data.UnitOfWork;

namespace MvcProject.Web.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(IUnitOfWork uow)
            : base(uow)
        {

        }

        public ActionResult Index()
        {
            return View();
        }

    }
}