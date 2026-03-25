namespace tp_agence_logement
{
    class Program
    {
        static void Main(string[] args)
        {

            Studio studio = new Studio("S01", "1 rue Lille", 20, 400, true, true);
            studio.Afficher();
            Console.WriteLine("Loyer calculé : " + studio.CalculerLoyer() + " euros");

            Appartement appart = new Appartement("A01", "2 rue Paris", 50, 800, true, 3);
            appart.Afficher();
            Console.WriteLine("Loyer calculé : " + appart.CalculerLoyer() + " euros");

            Maison maison = new Maison("M01", "3 rue Lyon", 100, 1200, true, 20);
            maison.Afficher();
            Console.WriteLine("Loyer calculé : " + maison.CalculerLoyer() + " euros");
        }
    }
}