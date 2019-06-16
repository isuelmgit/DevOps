using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevOps.Models
{
    public class Entrust
    {
        public string message { get; set; }
        public string to { get; set; }
        public string from { get; set; }
        public int timeToLifeSec { get; set; }
    }
}

