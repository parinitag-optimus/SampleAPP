﻿using System;
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
        public IPConnections()
        {
            IPAddress = string.Empty;
            Port = string.Empty;
            UserName = string.Empty;
            Password = string.Empty;
            Version = "6.0.0.24";
            Status = "Ready";

        }
        public string IPAddress
        {
            get;
            set;
        }

        public string Port
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
