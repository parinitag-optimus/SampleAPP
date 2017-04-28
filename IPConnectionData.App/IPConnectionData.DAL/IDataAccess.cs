using IPConnectionData.Model;
using System.Collections.Generic;

namespace IPConnectionData.DAL
{
    public interface IDataAccess
    {
        List<IPConnections> GetAllIPConnections();
        void AddConnection(IPConnections connection);
        List<Alarms> GetAllAlarms();
        List<JacquesDevices> GetAllJacquesDevices();
        void GetAlarmTags();
    }
}
