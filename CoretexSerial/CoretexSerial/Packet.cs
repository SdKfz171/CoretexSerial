using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoretexSerial
{
    public class Packet
    {
        public bool type { get; set; }  // true : receive, false : send
        public string message { get; set; }

    }
}
