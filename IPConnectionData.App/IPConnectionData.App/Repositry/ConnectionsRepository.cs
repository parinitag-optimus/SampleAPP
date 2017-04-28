using System.Collections.Generic;
using IPConnectionData.Model;
using IPConnectionData.DAL;
using System;

namespace IPConnectionData.App.Repositry
{
    public class ConnectionsRepository : IConnectionsRepository
    {
        private IDataAccess _data;
        public ConnectionsRepository(IDataAccess data) 
        {
            _data = data;
        }      

        /// <summary>
        /// Method for Adding a New Connection
        /// </summary>
        public void AddConnection(IPConnections connection)
        {
            _data.AddConnection(connection);
        }
        /// <summary>
        /// Method to get All Connections
        /// </summary>
        /// <returns></returns>
        public List<IPConnections> GetAllConnections()
        {
            List<IPConnections> ipConnectionData= _data.GetAllIPConnections();
            return ipConnectionData;
        }        
     }
}
