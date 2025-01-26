using Microsoft.AspNetCore.Mvc;

namespace Smartstore.Accounting.Controllers.Admin
{
    [Area("Admin")]
    public class AccountingController : Controller
    {
        [Route("/Pepino")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
