using IPConnectionData.Model;
using System.Collections.Generic;

namespace IPConnectionData.DAL
{

    /// <summary>
    /// Interface For DataAccess from DB
    /// GetAllIPConnection
    /// AddConnection
    /// GetAllAlarms
    /// GetAllJacquesDevices
    /// AddAndGetAlarmTagsList
    /// GetAlarmTagsList
    /// DeleteAlarmTags
    /// </summary>
    public interface IDataAccess
    {
        List<IPConnections> GetAllIPConnections();
        void AddConnection(IPConnections connection);
        List<Alarms> GetAllAlarms();
        List<JacquesDevices> GetAllJacquesDevices();
        List<AlarmsTags> AddAndGetAlarmTagsList(string alarm,string site,int tagId);
        List<AlarmsTags> GetAlarmTagsList();
        void DeleteAlarmTags(AlarmsTags alarmTags);
    }
}
