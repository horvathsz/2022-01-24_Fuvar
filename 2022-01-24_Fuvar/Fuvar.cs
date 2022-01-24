﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _2022_01_24_Fuvar
{
    class Fuvar
    {
        public int Taxi { get; set; }
        public DateTime Indulás  { get; set; }
        public int Időtartam { get; set; }
        public double Távolság { get; set; }
        public double Viteldíj { get; set; }
        public double Borravaló { get; set; }
        public string Fizetésmód { get; set; }

        public Fuvar(string sor)
        {
            string[] t = sor.Split(';');
            Taxi = int.Parse(t[0]);
            Indulás = DateTime.Parse(t[1]);
            Időtartam = int.Parse(t[2]);
            Távolság = double.Parse(t[3]);
            Viteldíj = double.Parse(t[4]);
            Borravaló = double.Parse(t[5]);
            Fizetésmód = (t[6]);
        }
    }
}
