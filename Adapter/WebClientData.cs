namespace Adapter
{
    public class WebClientData
    {
        public WebClientData(string v1, string v2, string v3, bool v4)
        {
            this.name = v1;
            this.ID = v2;
            this.IP = v3;
            this.SSL = v4;
        }

        public string name { get; set; }
        public string ID { get; set; }
        public string IP { get; set; }
        public bool SSL { get; set; }
    }
}