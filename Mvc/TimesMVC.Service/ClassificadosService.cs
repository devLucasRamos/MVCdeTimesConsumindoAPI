using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using TimesMVC.Core.Entities;

namespace TimesMVC.Service
{
    public class ClassificadosService
    {
        public async Task<List<Classificado>> FindAllAsync()
        {
            var client = new HttpClient();
            var streamTask = client.GetStreamAsync("http://localhost:19091/time/todos");
            var classificados = await JsonSerializer.DeserializeAsync<List<Classificado>>(await streamTask);
            return classificados;

        }
        /*
        var client = new HttpClient();
        var streamTask = client.GetStreamAsync("http://localhost:19091/time/todos");
        var classificados = await JsonSerializer.DeserializeAsync<List<ClassificadoViewModel>>(await streamTask);
        return View(classificados);
        */
    }
}
