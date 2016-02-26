using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyLibrary_sample1
{
    class Program
    {
        static void Main(string[] args)
        {
            Proxy proxy = new Proxy(19132);
            proxy.addServer(new ProxyLibrary.Server("127.0.0.1", 19133));
            proxy.Start();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "stop")
                {
                    if (proxy.isEnable())
                    {
                        proxy.Stop();
                        Console.WriteLine("プロキシを停止しました。");
                    }
                    else
                    {
                        Console.WriteLine("プロキシは停止中です。");
                    }
                }
                else if (command == "start")
                {
                    if (!proxy.isEnable())
                    {
                        proxy.Start();
                        Console.WriteLine("プロキシを起動しました。");
                    }
                    else
                    {
                        Console.WriteLine("プロキシは稼働中です。");
                    }
                }
                else if (command == "quit")
                {
                    if (proxy.isEnable())
                        proxy.Stop();
                    break;
                }
                else if (command == "clear")
                {
                    Console.Clear();
                }
            }
            Console.WriteLine();
            Console.Write("press any key...");
            Console.ReadKey();
        }
    }
}
