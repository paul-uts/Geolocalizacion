namespace Geolocalizacion.Models
{
    public class GeolocalizacionModel
    {
        public string status { get; set; }
        public string country { get; set; }
        public string regionName { get; set; }
        public string city { get; set; }
        public float lat { get; set; }
        public float lon { get; set; }
        public string query { get; set; }
    }
}
