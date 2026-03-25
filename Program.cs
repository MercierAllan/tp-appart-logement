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

            List<Logement> logements = new List<Logement>();
            logements.Add(studio);
            logements.Add(appart);
            logements.Add(maison);

            foreach (Logement logement in logements)
            {
                Console.WriteLine(" Détails du logement");
                logement.Afficher();
                Console.WriteLine("Loyer calculé : " + logement.CalculerLoyer() + " euros");
            }   

            Locataire loc1 = new Locataire(1, "Dupont", "0601020304");
            Locataire loc2 = new Locataire(2, "Martin", "0611223344");
            Locataire loc3 = new Locataire(3, "Durand", "0622334455");

            loc1.Afficher();
            loc2.Afficher();
            loc3.Afficher();
        }
    }
}