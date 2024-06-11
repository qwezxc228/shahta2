using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;
namespace shahta2
{
    internal class Mine
    {
        public int Ore {  get; set; }
        public int Worker { get; set; } = 1;
        public void Tick()
        {
            Ore += Worker;
        }
    }
}