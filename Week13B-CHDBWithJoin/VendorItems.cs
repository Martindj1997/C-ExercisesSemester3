using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week13B_CHDBWithJoin
{
    class VendorItem
    {
        public int Id { get; }
        public string Description { get; }
        public decimal Cost { get; }
        public string VendorName { get; }
        public decimal VendorTotalYTD { get; }

        public VendorItem(int id, string description, decimal cost, string vendorName, decimal vendorTotal)
        {
            Id = id;
            Description = description;
            Cost = cost;
            VendorName = vendorName;
            VendorTotalYTD = vendorTotal;
        }

        public override string ToString()
        {
            return $"{Id, 2}, {Description, -30}, {Cost, 7:C}, {VendorName, -30}, {VendorTotalYTD, 11:C}"; 
        }
    }

    class Item
    {
        public int Id { get; }
        public string Description { get; }
        public decimal Cost { get; }
        public int VendorId { get; }
        public Item(int id, string description, decimal cost, int vendorId)
        {
            Id = id;
            Description = description;
            Cost = cost;
            VendorId = vendorId;
        }
    }

    class Vendor
    {
        public int Id { get; }
        public string VendorName { get; }
        public decimal VendorTotalYTD { get; }
        public Vendor(int id, string name, decimal total)
        {
            Id = id;
            VendorName = name;
            VendorTotalYTD = total;
        }
    }
}
