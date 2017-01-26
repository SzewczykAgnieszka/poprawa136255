using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poprawa136255
{
    class Stacja:IKoszt,IComparable<Stacja>
    {
        private int ileDzienniePociagow;
        private string nazwaStacji;

        public Stacja(string nazwaStacji, int ileDzienniePociagow)
        {
            this.nazwaStacji = nazwaStacji;
            this.ileDzienniePociagow = ileDzienniePociagow;
        }

        public double ObliczKoszt()
        {
            double koszt = ileDzienniePociagow* 345.67;
            return koszt;
        }

        public override string ToString()
        {
            return "Stacja: " + nazwaStacji + ", liczba pociągów dziennie: " + ileDzienniePociagow;
        }

        public int CompareTo(Stacja other)
        {
            return other.nazwaStacji.CompareTo(this.nazwaStacji);
        }

    }
}
