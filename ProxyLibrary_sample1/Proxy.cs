using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProxyLibrary;

namespace ProxyLibrary_sample1
{
    public class Proxy : ProxyBase
    {
        public Proxy(int port)
        {
            this.proxy_port = port;
        }

        public override AnalyzeResult AnalyzeServer(Client client, Packet packet)
        {
            Console.WriteLine("{0}:{1} => {2}:{3}", packet.address.Address.ToString(), packet.address.Port, client.ip, client.port);
            
            return base.AnalyzeServer(client, packet);
        }

        public override AnalyzeResult AnalyzeClient(Client client, Packet packet)
        {
            Console.WriteLine("{0}:{1} => {2}:{3}", client.ip, client.port, client.ConnectingServer.ip, client.ConnectingServer.port);
            
            return base.AnalyzeClient(client, packet);
        }
    }
}
