using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week13B_QueueEx
{
    class DataPacket
    {
        private static int count = 1;
        public int Id { get; }
        public string Data { get; }
        public DateTime TimeStamp { get; }

        public DataPacket(string message)
        {
            Id = count++;
            Data = message;
            TimeStamp = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Id}, Data: {Data}";
        }
    }
}
