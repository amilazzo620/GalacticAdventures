using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAdventuresv2
{
    class Data
    {
        public String Name { get; set; }

        public String Location { get; set; }

        public List<Data> DataCollected { get; set; } = new List<Data>();

    }
}
