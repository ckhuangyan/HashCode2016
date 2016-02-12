using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode2016.Models
{
    public class Drone
    {
        public static int MaxWeight { get; set; }

        public int DroneId { get; set; }

        public Cell Position { get; set; }   

        public int Charges { get; set; }

        // 
        public bool IsOverCharged { get { return Charges > MaxWeight; } }
    }
}
