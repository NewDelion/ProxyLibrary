using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace ProxyLibrary
{
    public class AnalyzeResult
    {
        public enum Command
        {
            Send        = 0x01,
            Cancel      = 0x02
        }

        public Command result = Command.Send;
        public Packet packet;

        public AnalyzeResult(Command result, Packet packet)
        {
            this.result = result;
            this.packet = packet;
        }
    }
}
