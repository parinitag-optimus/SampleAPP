using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPConnectionData.Model
{
    /// <summary>
    /// Model For Alarms
    /// </summary>
    public class Alarms
    {
        public Alarms()
        {
            Alarm = string.Empty;
            Site = string.Empty;
        }
        public string Alarm
        {
            get;
            set;
        }

        public string Site
        { 
            get;
            set;
        }
    }
}
