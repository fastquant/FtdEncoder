using System;
using FtdEncoder;
using FtdEncoder.Messages;

namespace test1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            FtdPacket packet = new FtdPacket();
            byte[] buf = packet.ToData();
            Console.WriteLine("Hello World!");
        }
    }
}
