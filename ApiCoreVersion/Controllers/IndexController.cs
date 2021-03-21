using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCoreVersion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IndexController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
