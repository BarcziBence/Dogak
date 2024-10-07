using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doga
{
    internal class Versenyzo
    {

        public string Nev { get; set; }
        public int SzulEv { get; set; }
        public int Rajtszam { get; set; }
        public char Nem { get; set; }
        public string Kategoria { get; set; }
        public TimeSpan Uszas { get; set; }
        public TimeSpan ElsoDepo { get; set; }
        public TimeSpan Kerekpar { get; set; }
        public TimeSpan MasodikDepo { get; set; } 
        public TimeSpan Futas {  get; set; }

        public Versenyzo(string r)
        {
            string[] split = r.Split(';');
            Nev = split[0];
            SzulEv = int.Parse(split[1]);
            Rajtszam = int.Parse(split[2]);
            Nev = split[3];
            Kategoria = split[4];
            Uszas = TimeSpan.Parse(split[5]);
            ElsoDepo = TimeSpan.Parse(split[6]);
            Kerekpar = TimeSpan.Parse(split[7]);
            MasodikDepo = TimeSpan.Parse(split[8]);
            Futas = TimeSpan.Parse(split[9]);
        }

        public override string ToString()
        {
            return 
                $" Név: {Nev}, " +
                $"Születési év:{SzulEv}, " +
                $"Rajtszam:{Rajtszam}, Nem:{Nem}, " +
                $"Kategória:{Kategoria}" +
                $"Úszassal töltött idő : {Uszas}" +
                $"Első Depóban töltött idő: {ElsoDepo}" +
                $"Kerékpározással töltött idő: {Kerekpar}" +
                $"Második Depóban töltött idő: {MasodikDepo}" +
                $"Futással töltött idő: {Futas}";
        }
    }
}
