using MaxMind.GeoIP2;
using MaxMind.GeoIP2.Responses;

namespace IPLookUp
{
    public class GeoIP
    {
        private readonly DatabaseReader database;

        public GeoIP(string file)
        {
            database = new DatabaseReader(file);
        }

        public CityResponse queryIP(string ip)
        {
            return database.City(ip);
        }

        ~GeoIP()
        {
            database.Dispose();
        }
    }
}