using IPConnectionData.Model;
using System.Collections.Generic;

namespace IPConnectionData.DAL
{
    public interface IDataAccess
    {
        List<IPConnections> GetAllIPConnections();
        IPConnections AddConnection();
    }
}
