using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12B_CHDB
{
    class Medication
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public string Size { get; set; }
        public string Strength { get; set; }
        public string Sig { get; set; }
        public int UnitsUsed { get; set; }
        public DateTime Last { get; set; }

        public Medication(int id, string description, decimal cost, string size, string strength, string sig, int unitsUsed, DateTime last)
        {
            Id = id;
            Description = description;
            Cost = cost;
            Size = size;
            Strength = strength;
            Sig = sig;
            UnitsUsed = unitsUsed;
            Last = last;
        }

        public override string ToString()
        {
            return $"{Description, -25}, {Cost, 6:C}, {Last.Date.ToShortDateString()}";
        }
    }
}
