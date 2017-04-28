using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPConnectionData.Model;
using IPConnectionData.DAL;

namespace IPConnectionData.DAL
{
    public class DBAccess : IDataAccess
    {
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

        public void GetAlarmTags()
        {
            throw new NotImplementedException();
        }
    }
}
