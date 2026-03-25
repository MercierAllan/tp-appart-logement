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
        }
    }
}