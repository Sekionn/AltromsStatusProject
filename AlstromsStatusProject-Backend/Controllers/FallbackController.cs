using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace AlstromsStatusProject_Backend.Controllers
{
    public class FallbackController : Controller
    {
        public IActionResult Index()
        {
            return PhysicalFile(Path.Combine(Directory.GetCurrentDirectory(),
                "wwwroot", "index.html"), MediaTypeNames.Text.Html);
        }
    }
}
