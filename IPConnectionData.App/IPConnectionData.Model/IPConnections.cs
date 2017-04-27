using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPConnectionData.Model
{
    /// <summary>
    /// Model for IPConnections
    /// </summary>
    public class IPConnections
    {
        public int Id
        {
            get;
            set;
        }

        public string IPAddress
        {
            get;
            set;
        }

        public int Port
        {
            get;
            set;
        }

        public string UserName
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }

        public string Version
        {
            get;
            set;
        }

        public string Status
        {
            get;
            set;
        }

    }
}
