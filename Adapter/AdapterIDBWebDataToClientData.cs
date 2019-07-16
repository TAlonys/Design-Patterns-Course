namespace Adapter
{
    public class AdapterIDBWebDataToClientData : IDBWebData
    {
        public void Store(WebClientData wcd)
        {
            PerfectStore p = new PerfectStore();
            p.Store(new ClientData(wcd.ID, wcd.name));
        }
    }
}