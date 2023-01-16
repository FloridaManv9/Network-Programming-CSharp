using System;
using System.Net;

namespace CNT4704L
{
    class MySocketLab
    {
        static void Main()
        {
             
			Console.Write("Enter an IP Adress (e.g., x.x.x.x:  ");
			String stringIP = Console.ReadLine();
            IPAddress addr = IPAddress.Parse(stringIP);
            IPHostEntry hostt = Dns.GetHostEntry(stringIP);
            
			
			
            Console.Write("\n HostName of {0} is: {1} ", addr, hostt.HostName );
            
        }
    }
}
