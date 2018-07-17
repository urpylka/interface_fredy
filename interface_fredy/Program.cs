using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;

namespace interface_fredy
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialPort _serialPort = new SerialPort("COM3",56700,Parity.None,8,StopBits.One);
            _serialPort.Handshake = Handshake.None;
            _serialPort.Open();
            while (true)
            {
                if (Console.ReadKey().Key != ConsoleKey.Escape)
                {
                    char buffer = Console.ReadKey().KeyChar;
                    if (buffer != null)
                    {
                        _serialPort.Write(Convert.ToString(buffer));
                        //Thread.Sleep(100);
                        Console.Clear();
                    }
                }
                else break;
            }
            _serialPort.Close();
        }
        
    }
}
