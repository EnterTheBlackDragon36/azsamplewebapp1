using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace azsamplewebapp1.Controllers
{
    [Authorize]
    public class SecurityController : Controller
    {
        public static IConfiguration Configuration { get; set; }

        public SecurityController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public ActionResult Index()
        {
            return View("~/Views/Security/Security.cshtml");
        }
    }
}
