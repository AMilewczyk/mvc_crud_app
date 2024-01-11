using Microsoft.AspNetCore.Mvc;

namespace MvcCrudApp.Controllers
{
    public class MvcCrudAppController : Controller
    {
        [HttpPost]
        public IActionResult Create(Domain.Entities.MvcCrudApp mvcCrudapp)
        {
            return View();
        }
    }
}
