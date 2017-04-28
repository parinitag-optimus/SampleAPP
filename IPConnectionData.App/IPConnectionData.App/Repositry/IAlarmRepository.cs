using IPConnectionData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPConnectionData.App.Repositry
{

    /// <summary>
    /// Interface for Alarms
    /// </summary>
    interface IAlarmRepository
    {
        List<Alarms> GetAllAlarms();
        List<JacquesDevices> GetAllJacquesDevices();
        void GetAlarmTags();
    }
}
