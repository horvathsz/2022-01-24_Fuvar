using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2022_01_24_Fuvar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fuvar> fuvarok = new List<Fuvar>();

            foreach (var sor in File.ReadAllLines("fuvar.csv").Skip(1))
            {
                fuvarok.Add(new Fuvar(sor));
            }

            //3

            Console.WriteLine($"3. feladat: {fuvarok.Count} fuvar");

            //4

            double Bevétel = 0;
            int db = 0;
            foreach (var f in fuvarok)
            {
                if (f.Taxi == 6185)
                {
                    Bevétel += f.Viteldíj + f.Borravaló;
                    db++;
                }
            }

            Console.Write($"4. feladat: {db} fuvar alatt: {Bevétel}$");

            

            
            //5. feladat
            int bankkártyás = 0;
            int készpénz = 0;
            int ingyenes = 0;
            int vitatott = 0;
            int ismeretlen = 0;
            
            foreach (var f in fuvarok)
            {
                if (f.Fizetésmód == "bankkártya")
                {
                    bankkártyás++;
                }
                if (f.Fizetésmód == "készpénz")
                {
                    készpénz++;
                }
                if (f.Fizetésmód =="ingyenes")
                {
                    ingyenes++;
                }
                if (f.Fizetésmód =="vitatott")
                {
                    vitatott++;
                }
                if (f.Fizetésmód =="ismeretlen")
                {
                    ismeretlen++;

                }

            }
          

            /*5.b

            Dictionary<string, int> stat = new Dictionary<string, int>();
            foreach (var f in fuvarok)
            {
                if (stat.ContainsKey(f.Fizetésmód))
                {
                    stat[f.Fizetésmód]++;
                }
                else
                {
                    stat.Add(f.Fizetésmód, 1);
                }
            }
            Console.WriteLine($"5. feladat:");
            foreach (var s in Stat)
            {
                Console.WriteLine($"\t{s.Key}: {s.Value} fuvar");
            }*/




            fuvarok
                .GroupBy(x => x.Fizetésmód)
                .Select(g => new { FizetésMód = g.Key, db = g.Count() })
                .ToList()
                .ForEach(x => Console.WriteLine($"\t{x.FizetésMód}: {x.db}"));


            Console.ReadKey();
        }
    }
}
