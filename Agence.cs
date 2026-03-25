class Agence
{
    private string nom;
    private List<Logement> logements = new List<Logement>();
    private List<Locataire> locataires = new List<Locataire>();
    private List<ContratLocation> contrats = new List<ContratLocation>();

    public Agence(string nom)
    {
        this.nom = nom;
    }

    public void AjouterLogement(Logement l)
    {
        foreach (var lg in logements)
        {
            if (lg.Reference == l.Reference)
            {
                Console.WriteLine("Logement déjà existant : " + l.Reference);
                return;
            }
        }
        logements.Add(l);
    }

    public void AjouterLocataire(Locataire loc)
    {
        foreach (var l in locataires)
        {
            if (l.Id == loc.Id)
            {
                Console.WriteLine("Locataire déjà existant : " + loc.Id);
                return;
            }
        }
        locataires.Add(loc);
    }

    public void AjouterContrat(ContratLocation c)
    {
        if (c == null)
        {
            Console.WriteLine("Contrat invalide.");
            return;
        }

        if (!locataires.Contains(c.Locataire))
        {
            Console.WriteLine("Locataire non enregistré.");
            return;
        }
        if (!logements.Contains(c.Logement))
        {
            Console.WriteLine("Logement non enregistré.");
            return;
        }

        contrats.Add(c);
    }

    public void AfficherLogements()
    {
        foreach (var l in logements)
            l.Afficher();
    }

    public void AfficherLocataires()
    {
        foreach (var loc in locataires)
            loc.Afficher();
    }

    public void AfficherContrats()
    {
        foreach (var c in contrats)
            c.Afficher();
    }

    public void AfficherLogementsDisponibles()
    {
        foreach (var l in logements)
        {
            if (l.Disponible)
                l.Afficher();
        }
    }
}