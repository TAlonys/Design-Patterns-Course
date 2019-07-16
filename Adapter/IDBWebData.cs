using System;

namespace Adapter
{
    public interface IDBWebData
    {
        void Store(WebClientData wcd);
    }
}