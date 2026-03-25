using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_2026_03_25_ba
{
    internal class auto
    {
        int id;
        string marka;
        string tipus;
        int evjarat;
        string szin;
        int ar;
        bool torott;

        public auto(int id, string marka, string tipus, int evjarat, string szin, int ar, bool torott)
        {
            this.id = id;
            this.marka = marka;
            this.tipus = tipus;
            this.evjarat = evjarat;
            this.szin = szin;
            this.ar = ar;
            this.torott = torott;
        }

        public int Id { get => id; set => id = value; }
        public string Marka { get => marka; set => marka = value; }
        public string Tipus { get => tipus; set => tipus = value; }
        public int Evjarat { get => evjarat; set => evjarat = value; }
        public string Szin { get => szin; set => szin = value; }
        public int Ar { get => ar; set => ar = value; }
        public bool Torott { get => torott; set => torott = value; }
    }
}
