using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace PingMan.BusinessLogic
{
    public class PingHistory
    {
        public string Address { get; set; }
        public DateTime DateTime { get; set; }
        public IPStatus Status { get; set; }

        public PingHistory(string address, IPStatus status)
        {
            Address = address;
            Status = status;
            DateTime = DateTime.Now;
        }
    }
}
