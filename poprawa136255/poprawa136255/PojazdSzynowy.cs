using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poprawa136255
{
    abstract class PojazdSzynowy:IKoszt
    {
        protected string marka;
        protected int masa;

        protected PojazdSzynowy() { }

        public PojazdSzynowy(string marka, int masa)
        {
            this.marka = marka;
            this.masa = masa;
        }

        abstract public double ObliczKoszt();


        abstract public void Info();

    }
}
