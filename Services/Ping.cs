namespace DiFuncApp.Services
{
    public class Ping : IPing
    {
        public string PingHost(string host)
        {
            return $"{host} is ponging";
        }
    }
}