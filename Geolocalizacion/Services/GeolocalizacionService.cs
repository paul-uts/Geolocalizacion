using System.Text.Json;
using Geolocalizacion.Models;

namespace Geolocalizacion.Services
{
    public class GeolocalizacionService
    {
        private HttpClient _client = new HttpClient();

        public async Task<GeolocalizacionModel> ObtenerPorIp(string ip)
        {
            string url = $"http://ip-api.com/json/{ip}";
            var response = await _client.GetStringAsync(url);

            GeolocalizacionModel data = JsonSerializer.Deserialize<GeolocalizacionModel>(response);

            return data;
        }
    }
}
