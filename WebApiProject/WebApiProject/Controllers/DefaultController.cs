using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPIProject.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("/")]
    public class DefaultController : ControllerBase
    {
        [HttpGet()]
        public string Index() {
            return " Running...";
        }

    }
}
