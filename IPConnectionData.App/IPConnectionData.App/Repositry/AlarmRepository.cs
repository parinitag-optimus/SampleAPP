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

        public void GetAlarmTags()
        {
            _data.GetAlarmTags();
        }

        public List<Alarms> GetAllAlarms()
        {
            List<Alarms> alarmsData = _data.GetAllAlarms();
            return alarmsData;
        }

        public List<JacquesDevices> GetAllJacquesDevices()
        {
            List<JacquesDevices> devices = _data.GetAllJacquesDevices();
            return devices;
        }
    }
}
