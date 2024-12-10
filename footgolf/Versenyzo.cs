using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace footgolf
{
    internal class Versenyzo
    {
        public string Nev { get; set; }

        public string Kategoria { get; set; }

        public string Csapat { get; set; }

        public int pont1 { get; set; }

        public int pont2 { get; set; }

        public int pont3 { get; set; }

        public int pont4 { get; set; }

        public int pont5 { get; set; }

        public int pont6 { get; set; }

        public int pont7 { get; set; }

        public int pont8 { get; set; }


        public Versenyzo(string sor)
        {
            string[] s = sor.Split(';');

            Nev = s[0];

            Kategoria = s[1];

            Csapat = s[2];

            pont1 = int.Parse(s[3]);

            pont2 = int.Parse(s[4]);

            pont3 = int.Parse(s[5]);

            pont4 = int.Parse(s[6]);

            pont5 = int.Parse(s[7]);

            pont6 = int.Parse(s[8]);

            pont7 = int.Parse(s[9]);

            pont8 = int.Parse(s[10]);

        }

    }
}
