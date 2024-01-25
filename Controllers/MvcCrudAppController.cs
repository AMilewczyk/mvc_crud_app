using Microsoft.AspNetCore.Mvc;
using MvcCrudApp.Application.Services;

namespace MvcCrudApp.Controllers
{
    public class MvcCrudAppController : Controller
    {
        private readonly IMvcCrudAppServices _mvcCrudppServices;

        public MvcCrudAppController(IMvcCrudAppServices mvcCrudppServices)
        {
            _mvcCrudppServices = mvcCrudppServices;
        }

        
        public ActionResult Create() 
        {
            return View();
        }
        

        [HttpPost]
        public async Task<IActionResult> Create(Domain.Entities.MvcCrudApp mvcCrudapp)
        {
            await _mvcCrudppServices.Create(mvcCrudapp);
            return RedirectToAction(nameof(Create)); //TODO: refactor
        }
    }
}
