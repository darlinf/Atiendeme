using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Atiendeme.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Atiendeme.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        [HttpPost]
        public IActionResult Appointment([FromBody]Appointment appointment)
        {
            var pp = appointment;
            return Ok(new {
                userId = 4
            });
        }

	[HttpGet]
        public IActionResult Appointment2()
        {
            return Ok(new {
                userId = 4
            });
        }
    }
}