using Accountash.Presentation.BaseController;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accountash.Presentation.Controller
{
    public sealed class TestController: ApiController
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Başarılı test.");
        }
    }
}
