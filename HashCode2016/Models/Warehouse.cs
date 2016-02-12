using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode2016.Models
{
    public class Warehouse
    {
        public int WarehouseId { get; set; }

        public Cell Position { get; set; } 

        public List<Product> Products { get; set; }
    }
}
