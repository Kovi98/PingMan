using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Text;

namespace PingMan.BusinessLogic
{
    public class PingedIP
    {
        public string Address { get; set; }
        public int TimerSecs { get; set; }

        public IList<PingHistory> History { get; set; }

        public BackgroundWorker Worker { get; set; }

        public PingedIP(string address, int timerSecs)
        {
            Address = address;
            TimerSecs = timerSecs;
        }

        public PingReply Ping()
        {
            var pinger = new Ping();
            return pinger.Send(Address);
        }

        public void MakePing()
        {
            var status = this.Ping();

            History.Add(new PingHistory(Address, status.Status));
        }

        public void Start()
        {

        }

        public void Stop()
        {

        }
    }
}
