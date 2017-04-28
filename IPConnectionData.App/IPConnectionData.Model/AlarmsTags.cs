using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPConnectionData.Model
{
    /// <summary>
    /// Model for Alarm Mapping
    /// </summary>
    public class AlarmsTags
    {
        public AlarmsTags()
        {
            AvigilionAlarm = string.Empty;
            AvigilionSite = string.Empty;
           
        }
        public string AvigilionAlarm
        {
            get;
            set;
        }

        public string AvigilionSite
        {
            get;
            set;
        }

        public int JacquesTagId
        {
            get;
            set;
        }
    }
}
