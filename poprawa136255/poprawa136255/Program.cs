using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poprawa136255
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PojazdSzynowy> ciuchcia = new List<PojazdSzynowy>();
            ciuchcia.Add(new Lokomotywa("Lo1", 5000));
            ciuchcia.Add(new Wagon("Wt1", 3000, null));
            ciuchcia.Add(new Wagon("Wt1", 2000, "węgiel"));
            ciuchcia.Add(new Wagon("Wt2", 3000, "drewno"));
            ciuchcia.Add(new Wagon("Wt2", 4000, "drewno"));
            ciuchcia.Add(new Wagon("Wt2", 3500, "drewno"));
            ciuchcia.Add(new Wagon("Wt3", 2500, null));
            ciuchcia.Add(new Wagon("Wt3", 1500, null));
            ciuchcia.Add(new Wagon("Wt3", 3000, null));
            ciuchcia.Add(new Wagon("Wt3", 2000, null));

            foreach (var obiekt in ciuchcia)
            {
                obiekt.Info();
            }

            double lacznyKoszt = 0;

            foreach (var obiekt in ciuchcia)
            {
                lacznyKoszt += obiekt.ObliczKoszt();
            }
            Console.WriteLine("Łączny koszt: {0}", lacznyKoszt);

            Console.WriteLine("");

            Queue<Stacja> stacje = new Queue<Stacja>();
            stacje.Enqueue(new Stacja("Malbork", 20));
            stacje.Enqueue(new Stacja("Olsztyn", 30));
            stacje.Enqueue(new Stacja("Kętrzyn", 6));
            stacje.Enqueue(new Stacja("Elbląg", 15));
            stacje.Enqueue(new Stacja("Ełk", 14));


            foreach (var obiekt in stacje)
            {
                double koszt = obiekt.ObliczKoszt();
                Console.WriteLine( koszt);
            }

            Console.WriteLine("");

            List<Stacja> miasta = new List<Stacja>();

            foreach (var obiekt in stacje)
            {
                miasta.Add(obiekt);
            }

            miasta.Sort();

            for (int i = miasta.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(miasta[i].ToString());
            }

            Console.ReadKey();
        }
    }
}
