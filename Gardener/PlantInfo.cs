using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gardener
{
    public class PlantInfo
    {
        public PlantInfo(string name, string desc, int waterAmt, int waterTime, DateTime addDate)
        {
            Name = name;
            Description = desc;
            WaterAmt = waterAmt;
            WaterTime = waterTime;
            AddDate = addDate;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int WaterAmt { get; set; }
        public int WaterTime { get; set; }
        public DateTime AddDate { get; set; }
    }
}
