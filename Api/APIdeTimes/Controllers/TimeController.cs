using APIdeTimes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace APIdeTimes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TimeController : Controller
    {

        private readonly ILogger<TimeController> _logger;

        public TimeController(ILogger<TimeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("todos")]
        public JsonResult GetAll()
        {
            List<Object> times = new List<object>();

            times.Add(new Time { Nome = "Flamengo", FundadoEm = 1717, Titulos = 99 });
            times.Add(new Time { Nome = "Palmeras", FundadoEm = 1878, Titulos = 0 });
            times.Add(new Time { Nome = "Gremio", FundadoEm = 1945, Titulos = 21 });
            times.Add(new Time { Nome = "Vasco", FundadoEm = 1899, Titulos = 12 });
            times.Add(new Time { Nome = "Botafogo", FundadoEm = 1923, Titulos = 34 });
            times.Add(new Time { Nome = "Corinthians", FundadoEm = 1983, Titulos = 65 });
            times.Add(new Time { Nome = "Guarani", FundadoEm = 1678, Titulos = 76 });

            return Json(times);
        }
    }
}
