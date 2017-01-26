using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poprawa136255
{
    class Wagon:PojazdSzynowy
    {
        private string ladunek;

        public Wagon(string marka, int masa, string ladunek)
        {
            base.marka = marka;
            base.masa = masa;
            this.ladunek = ladunek;
            this.ObliczKoszt();
        }
        public override double ObliczKoszt()
        {
            if (ladunek == null)
            {
                double koszt = 3000;
                return koszt;
            }
            else
            {
                double koszt = 3000+masa;
                return koszt;
            }
        }

        public override void Info()
        {
            Console.WriteLine("Wagon, model: " + marka + ", masa: " + masa);
        }

    }
}
