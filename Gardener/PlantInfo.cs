using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gardener
{
    public class PlantInfo
    {
        public PlantInfo(string name, string desc, string waterAmt, string waterTime)
        {
            Name = name;
            Description = desc;
            WaterAmt = waterAmt;
            WaterTime = waterTime;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string WaterAmt { get; set; }
        public string WaterTime { get; set; }
    }
}
