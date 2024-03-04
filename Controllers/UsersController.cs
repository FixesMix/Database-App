using Microsoft.AspNetCore.Mvc;
using Aura.Models;

namespace Aura.Controllers
{
    public class UsersController : Controller
    {
        UsersContext uc = new();
        public IActionResult AuraView()
        {
            return View(uc.AuraTables.ToList());
        }
    }
}
