using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poprawa136255
{
    class Lokomotywa:PojazdSzynowy
    {
        public Lokomotywa(string marka, int masa)
        {
            base.marka = marka;
            base.masa = masa;
            this.ObliczKoszt();
        }

        public override double ObliczKoszt()
        {
            double koszt = masa*34;
            return koszt;
        }

        public override void Info()
        {
            Console.WriteLine("Lokomotywa, model: " + marka + ", masa: " + masa);
        }
    }
}
