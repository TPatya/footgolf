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

        public int[] pontok { get; set; }




        public Versenyzo(string sor)
        {
            string[] s = sor.Split(';');

            Nev = s[0];

            Kategoria = s[1];

            Csapat = s[2];



            pontok = new int[8];

            for (int i = 0; i < pontok.Length; i++)
            {
                pontok[i] = int.Parse(s[i + 3]);
            }

      

        }

    }
}
