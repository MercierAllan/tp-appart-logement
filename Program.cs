class Program
{
    static void Main()
    {

        Studio s1 = new Studio("S1", "Paris", 20, 500, true, true);
        Appartement a1 = new Appartement("A1", "Lyon", 60, 800, true, 3);
        Maison m1 = new Maison("M1", "Lille", 100, 1200, true, 50);
        List<Logement> logements = new List<Logement> { s1, a1, m1 };
        foreach (var l in logements)
        {
            l.Afficher();
            Console.WriteLine("Loyer calculé : " + l.CalculerLoyer() + " euros");
            Console.WriteLine();
        }

        Locataire alice = new Locataire(1, "Alice", "0601010101");
        Locataire bob = new Locataire(2, "Bob", "0602020202");
        Locataire ines = new Locataire(3, "Inès", "0603030303");

        List<Locataire> locataires = new List<Locataire> { alice, bob, ines };
        foreach (var loc in locataires)
        {
            loc.Afficher();
            Console.WriteLine();
        }

        ContratLocation c101 = new ContratLocation(101, alice, s1, 5);
        ContratLocation c102 = new ContratLocation(102, bob, a1, 3);
        ContratLocation c103 = new ContratLocation(103, ines, m1, 7);

        List<ContratLocation> contrats = new List<ContratLocation> { c101, c102, c103 };
        foreach (var c in contrats)
        {
            c.Afficher();
            Console.WriteLine();
        }

        foreach (var l in logements)
        {
            if (l is Maison m)
                Console.WriteLine("Maison avec jardin de " + m.CalculerLoyer() + " euros de loyer");
            else if (l is Studio st)
                Console.WriteLine("Studio avec loyer " + st.CalculerLoyer() + " euros");
            else if (l is Appartement ap)
                Console.WriteLine("Appartement avec loyer " + ap.CalculerLoyer() + " euros");
        }

        Console.WriteLine(s1);
        Console.WriteLine(a1);
        Console.WriteLine(m1);
        Console.WriteLine(alice);
        Console.WriteLine(bob);
        Console.WriteLine(ines);
    }
}