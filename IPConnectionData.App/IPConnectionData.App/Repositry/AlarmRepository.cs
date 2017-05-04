using IPConnectionData.DAL;
using IPConnectionData.Model;
using System.Collections.Generic;
using System;

namespace IPConnectionData.App.Repositry
{
    public class AlarmRepository:IAlarmRepository
    {
        private IDataAccess _data;
        public AlarmRepository(IDataAccess data)
        {
            _data = data;
        }

        /// <summary>
        /// Method to add and Display a new AlarmTag  
        /// </summary>
        /// <param name="alarm"></param>
        /// <param name="site"></param>
        /// <param name="tagId"></param>
        /// <returns></returns>

        public List<AlarmsTags> AddAndGetAlarmTagsList(string alarm, string site, int tagId)
        {
            List<AlarmsTags> alarmTags=_data.AddAndGetAlarmTagsList(alarm,site,tagId);
            return alarmTags;
        }

        public void DeleteAlarmsTags(AlarmsTags SelectedAlarmsTags)
        {
            _data.DeleteAlarmTags(SelectedAlarmsTags);
           
        }

        /// <summary>
        /// method to get list OF alarmTags
        /// </summary>
        /// <returns></returns>
        public List<AlarmsTags> GetAlarmTagsList()
        {
            List<AlarmsTags> alarmTags = _data.GetAlarmTagsList();
            return alarmTags;
        }
        /// <summary>
        /// method to get all the Avigilion Alarms
        /// </summary>
        /// <returns></returns>
        public List<Alarms> GetAllAlarms()
        {
            List<Alarms> alarmsData = _data.GetAllAlarms();
            return alarmsData;
        }
        /// <summary>
        /// Method to Get all the Jacques Devices
        /// </summary>
        /// <returns></returns>
        public List<JacquesDevices> GetAllJacquesDevices()
        {
            List<JacquesDevices> devices = _data.GetAllJacquesDevices();
            return devices;
        }
    }
}
