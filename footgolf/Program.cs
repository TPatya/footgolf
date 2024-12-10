namespace footgolf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Versenyzo> versenyzok = new();

            foreach (var sor in File.ReadAllLines("fob2016.txt"))
            {
                versenyzok.Add(new Versenyzo(sor));
            }
            Console.WriteLine($"3.Feladat: \t Versenyzők száma: {versenyzok.Count()}");


            int nok = 0;
            foreach (var s in versenyzok)
            {
                if (s.Kategoria == "Noi")
                {
                    nok++;
                }
            }
            Console.WriteLine($"4.Feladat: \t A női versenyzők aránya: {versenyzok.Count() / nok:0.0.0} %");
            
        }
    }
}
