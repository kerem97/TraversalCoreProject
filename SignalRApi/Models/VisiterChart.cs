using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRApi.Models
{
    public class VisiterChart
    {
        public VisiterChart()
        {
            Counts = new List<int>();
        }

        public string VisitDate { get; set; }
        public List<int> Counts { get; set; }
    }
}
