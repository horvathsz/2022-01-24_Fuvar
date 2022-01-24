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

            Console.ReadKey();
        }
    }
}
