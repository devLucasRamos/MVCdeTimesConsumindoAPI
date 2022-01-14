using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using TimeMVC.ViewModels;
using TimesMVC.Core.Entities;
using TimesMVC.Service;

namespace TimesMVC.Controllers
{
    public class TimeController : Controller
    {
        private readonly TimeService _timeService;
        public TimeController(TimeService timeService)
        {
            _timeService = timeService;
        }

        public IActionResult Index()
        {
            var list = _timeService.FindAll();
            List<TimeViewModel> results = new List<TimeViewModel>();
            list.ForEach(x =>
            {
                results.Add(new TimeViewModel()
                {
                    Id = x.Id,
                    Nome = x.Nome,
                    Rival = x.Rival,
                    Fundado = x.Fundado,
                    Titulos = x.Titulos,
                });
            });

            return View(results);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TimeViewModel time)
        {
            Time model = new Time()
            {
                Id = time.Id,
                Nome = time.Nome,
                Fundado = time.Fundado,
                Rival = time.Rival,
                Titulos = time.Titulos,

            };
            _timeService.CreateTime(model);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            _timeService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var obj = _timeService.FindById(id);
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Time time)
        {
            _timeService.Update(time);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ClassificadosAsync(List<Classificado> classificados)
        {
            var client = new HttpClient();
            var streamTask = client.GetStreamAsync("http://localhost:19091/time/todos");
            classificados = await JsonSerializer.DeserializeAsync<List<Classificado>>(await streamTask);
            return View(classificados);
        }
    }
}
