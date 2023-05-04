using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gardener
{
    internal class PlantAdding
    {
        public List<PlantInfo> plants = new List<PlantInfo>();

        public void PlantAdd(PlantInfo plant)
        {
            plants.Add(plant);
        }
        
    }
}
