using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    public class Station
    {
        public string StationName { get; set; }
        public int ScreenID { get; set; }
        public DateTime Date { get; set; }
        public decimal DepthToWaterLevel { get; set; }
        public string Comment { get; set; }
    }
}
