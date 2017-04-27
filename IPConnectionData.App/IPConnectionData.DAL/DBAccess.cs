using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPConnectionData.Model;

namespace IPConnectionData.DAL
{
    public class DBAccess : IDataAccess
    {
        public IPConnections AddConnection()
        {
            throw new NotImplementedException();
        }

        public List<IPConnections> GetAllIPConnections()
        {
            List<IPConnections> ipConnectionData = new List<IPConnections>();
            IPConnectionDBEntities ipConnectionDBEntities = new IPConnectionDBEntities();
            var connectionQuery = (from connections in ipConnectionDBEntities.IPConnectionsTables
                           select connections).ToList();
            foreach(var ipConnections in connectionQuery)
            {
                ipConnectionData.Add(new IPConnections());
            }
            return ipConnectionData;

        }
    }
}
