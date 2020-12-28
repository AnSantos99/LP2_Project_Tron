using System;
using System.Threading;

namespace Tron
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(".");
                Thread.Sleep(500);
            }
        }
    }
}
