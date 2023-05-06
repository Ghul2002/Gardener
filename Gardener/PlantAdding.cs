using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gardener
{
    public class PlantAdding
    {
        public static List<PlantInfo> plants = new List<PlantInfo>();

        public static void PlantAdd(PlantInfo plant)
        {
            plants.Add(plant);
        }
        
    }
}
