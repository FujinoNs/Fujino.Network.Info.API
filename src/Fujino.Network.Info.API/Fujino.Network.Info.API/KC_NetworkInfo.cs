namespace FujinoNs.NetworkInfo
{
    public class KC_NetworkInfo
    {
        Json_Modul _Modul;
        public KC_NetworkInfo()
        {
            _Modul = Newtonsoft.Json.JsonConvert.DeserializeObject<Json_Modul>(new System.Net.WebClient().DownloadString("http://ip-api.com/json/"));
        }

        public string Status()
        {
            return _Modul.status;
        }

        public string Country()
        {
            return _Modul.country + " (" + _Modul.countryCode + ")";
        }

        public string RegionName()
        {
            return _Modul.regionName;
        }

        public string City()
        {
            return _Modul.city;
        }

        public string TimeZone()
        {
            return _Modul.timezone;
        }

        public string ISP()
        {
            return _Modul.isp;
        }

        public string IPAddress()
        {
            return _Modul.query;
        }
    }

}
