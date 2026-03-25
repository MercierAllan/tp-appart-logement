namespace tp_agence_logement
{
    class Program
    {
        static void Main(string[] args)
        {
            Logement logement1 = new Logement("REF01", "10 rue de Paris", 30, 500, true);
            logement1.Afficher();
            Console.WriteLine("Loyer calculé : " + logement1.CalculerLoyer() + " euros");

            Logement logement2 = new Logement("REF02", "20 rue de Lyon", 40, 400, true);
            logement2.Afficher();

            Studio studio = new Studio("S01", "1 rue Lille", 20, 400, true, true);
            studio.Afficher();

            Appartement appart = new Appartement("A01", "2 rue Paris", 50, 800, true, 3);
            appart.Afficher();

            Maison maison = new Maison("M01", "3 rue Lyon", 100, 1200, true, 200);
            maison.Afficher();

            Appartement appartInvalide = new Appartement("A02", "4 rue Nice", 60, 900, true, 0);
            appartInvalide.Afficher();
        }
    }
}