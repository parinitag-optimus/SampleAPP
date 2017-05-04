using IPConnectionData.Model;
using System.Collections.Generic;

namespace IPConnectionData.App.Repositry
{

    /// <summary>
    /// Interface declarations for Alarms
    /// GetAll Alarms
    /// GetAllJacquesDevices
    /// AddAndGetAlarmsTagsList
    /// GetAlarmsTagsList
    /// </summary>
    interface IAlarmRepository
    {
        List<Alarms> GetAllAlarms();
        List<JacquesDevices> GetAllJacquesDevices();
        List<AlarmsTags> AddAndGetAlarmTagsList(string alarm,string site,int tagId);
        List<AlarmsTags> GetAlarmTagsList();
        void DeleteAlarmsTags(AlarmsTags SelectedAlarmsTags);
    }
}
