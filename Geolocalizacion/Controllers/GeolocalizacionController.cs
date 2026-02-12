using Geolocalizacion.Services;
using Microsoft.AspNetCore.Mvc;

namespace Geolocalizacion.Controllers
{
    public class GeolocalizacionController : Controller
    {
        private readonly GeolocalizacionService _service;

        public GeolocalizacionController()
        {
            _service = new GeolocalizacionService();
        }

        public IActionResult Index()
        {



















            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string ip)
        {
            if (string.IsNullOrEmpty(ip))
            {
                ViewBag.Error = "Ingresa una IP válida";
                return View();
            }

            var resultado = await _service.ObtenerPorIp(ip);

            return View(resultado);
        }
    }
}
