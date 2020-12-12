using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Week13B_QueueEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<DataPacket> packets = new Queue<DataPacket>();
            DateTime startTime = DateTime.Now;

            for (int counter = 1; ; counter++)  // while (true)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"Time Elapsed(s): {counter}");
                if (counter % 3 == 0)
                {
                    packets.Enqueue(new DataPacket("Computer 1 Message"));
                    Console.WriteLine("\tComputer 1 Message added to Queue");
                }
                if (counter % 5 == 0)
                {
                    packets.Enqueue(new DataPacket("Computer 2 Message"));
                    Console.WriteLine("\tComputer 2 Message added to Queue");
                }
                if (counter % 7 == 0)
                {
                    packets.Enqueue(new DataPacket("Computer 3 Message"));
                    Console.WriteLine("\tComputer 3 Message added to Queue");
                }

                if (counter < 15)  // router is supposed to wait 10 seconds
                    continue;
                else  // 10 seconds have elapsed, router will now start sending packets
                {
                    if (packets.Count == 0) // queue is empty
                    {
                        Console.WriteLine($"\tQueue is empty, no message remaining");
                        break; // exit loop
                    }

                    // packets remaining in the queue, so we need to process them.
                    DataPacket packet = packets.Dequeue();
                    TimeSpan queuedTime = DateTime.Now - packet.TimeStamp;
                    Console.WriteLine($"\t message removed from queue: {packet}; Queued For(s): {queuedTime.TotalSeconds:F0}; Queue Count: {packets.Count}");
                }
            }
            Console.ReadKey();
        }
    }
}
