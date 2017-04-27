using IPConnectionData.Model;
using System.Collections.Generic;

namespace IPConnectionData.App.Repositry
{
    public interface IConnectionsRepository
    {
        /// <summary>
        /// Interface declaratios of methods for Connections
        /// GetConnections
        /// Add Connections
        /// </summary>
        /// <returns></returns>
        List<IPConnections> GetAllConnections();
        void AddConnection();
    }
}
