using System;
using System.Collections.Generic;
using System.Linq;
using IPConnectionData.Model;

namespace IPConnectionData.DAL
{
    public class DBAccess : IDataAccess
    {
        /// <summary>
        /// Method to Add a new Connection to Database
        /// </summary>
        /// <param name="connection"></param>
        public void AddConnection(IPConnections connection)
        {
            IPConnectionDBEntities ipConnectionDBEntities = new IPConnectionDBEntities();
            var newConnection = new IPConnectionsTable 
            {
                IPAddress = connection.IPAddress,
                Port = connection.Port,
                UserName=connection.UserName,
                Password=connection.Password,
                Version = connection.Version,
                Status = connection.Status
            };
            ipConnectionDBEntities.IPConnectionsTables.Add(newConnection);
            ipConnectionDBEntities.SaveChanges();
        }

        /// <summary>
        /// Method to GetAllIPConnection from DB
        /// </summary>
        /// <returns></returns>

        public List<IPConnections> GetAllIPConnections()
        {
            List<IPConnections> ipConnectionData = new List<IPConnections>();
            IPConnectionDBEntities ipConnectionDBEntities = new IPConnectionDBEntities();
            var connectionQuery = (from connections in ipConnectionDBEntities.IPConnectionsTables
                           select connections).ToList();
            foreach(var ipConnections in connectionQuery)
            {
                ipConnectionData.Add(new IPConnections
                {
                    IPAddress = ipConnections.IPAddress,
                    Version = ipConnections.Version,
                    Status = ipConnections.Status
                });
            }
            return ipConnectionData;
        }    

        /// <summary>
        /// Method To Get Alarms From DB
        /// </summary>
        /// <returns></returns>
        public List<Alarms> GetAllAlarms()
        {
            List<Alarms> alarmsData = new List<Alarms>();
            IPConnectionDBEntities ipConnectionDBEntities = new IPConnectionDBEntities();
            var connectionQuery = (from alarms in ipConnectionDBEntities.Alarms
                                   select alarms).ToList();
            foreach (var alarms in connectionQuery)
            {
                alarmsData.Add(new Alarms
                {
                    Alarm= alarms.Alarm1,
                    Site= alarms.Site

                });
            }
            return alarmsData;
        }

        /// <summary>
        /// Method To Get All Jacques Devices
        /// </summary>
        /// <returns></returns>
        public List<JacquesDevices> GetAllJacquesDevices()
        {
            List<JacquesDevices> tagdevices = new List<JacquesDevices>();
            IPConnectionDBEntities ipConnectionDBEntities = new IPConnectionDBEntities();
            var connectionQuery = (from devices in ipConnectionDBEntities.JacquesTagTables
                                   select devices).ToList();
            foreach (var devices in connectionQuery)
            {
                tagdevices.Add(new JacquesDevices
                {
                    TagId = devices.JacquesTagId,
                    TagStatus = devices.TagStatus,
                    TagName=devices.TagName
                });
            }
            return tagdevices;
        }

        /// <summary>
        /// Method To Add and Display New Alarm Tag
        /// </summary>
        /// <param name="alarm"></param>
        /// <param name="site"></param>
        /// <param name="TagId"></param>
        /// <returns></returns>

        public List<AlarmsTags> AddAndGetAlarmTagsList(string alarm,string site,int TagId)
        {
            IPConnectionDBEntities ipConnectionDBEntities = new IPConnectionDBEntities();
            var newConnection = new AlarmsTagsTable
            {
                Alarm=alarm,
                AlarmSite=site,
                JacquesTagId=TagId
            };
            ipConnectionDBEntities.AlarmsTagsTables.Add(newConnection);
            ipConnectionDBEntities.SaveChanges();
            List<AlarmsTags> alarmtagdevices = new List<AlarmsTags>();
            alarmtagdevices=GetAlarmTagsList();
            return alarmtagdevices;
        }

        /// <summary>
        /// Method To Get All AlarmsTags From DB
        /// </summary>
        /// <returns></returns>

        public List<AlarmsTags> GetAlarmTagsList()
        {
            List<AlarmsTags> alarmtagdevices = new List<AlarmsTags>();
            IPConnectionDBEntities ipConnectionDBEntities = new IPConnectionDBEntities();
            var connectionQuery = (from alarmTags in ipConnectionDBEntities.AlarmsTagsTables
                                   select alarmTags).ToList();
            foreach (var devices in connectionQuery)
            {
                alarmtagdevices.Add(new AlarmsTags
                {
                    AvigilionAlarm = devices.Alarm,
                    AvigilionSite = devices.AlarmSite,
                    JacquesTagId = (int)devices.JacquesTagId
                });
            }
            return alarmtagdevices;
        }
        /// <summary>
        /// Method to delete alarm Tags
        /// </summary>
        /// <param name="alarmTags"></param>
        public void DeleteAlarmTags(AlarmsTags alarmTags)
        {
            IPConnectionDBEntities ipConnectionDBEntities = new IPConnectionDBEntities();
            var connectionQuery = (from alarmTagslist in ipConnectionDBEntities.AlarmsTagsTables
                                   where alarmTagslist.Alarm ==alarmTags.AvigilionAlarm 
                                   && alarmTagslist.AlarmSite== alarmTags.AvigilionSite
                                   select alarmTagslist).FirstOrDefault();
            ipConnectionDBEntities.AlarmsTagsTables.Remove(connectionQuery);
            ipConnectionDBEntities.SaveChanges();


        }
    }
}
