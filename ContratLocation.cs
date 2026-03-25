class ContratLocation
{
    private int numero;
    private Locataire locataire;
    private Logement logement;
    private int nombreJours;
    private double tarifJournalier;

    public Locataire Locataire { get; internal set; }
    public Logement Logement { get; internal set; }

    public ContratLocation(int numero, Locataire locataire, Logement logement, int nombreJours)
    {
        this.numero = numero;
        this.locataire = locataire;

        if (!logement.Disponible)
        {
            Console.WriteLine("Le logement n'est pas disponible. Contrat non créé.");
            this.logement = null;
            return;
        }

        if (nombreJours <= 0)
        {
            Console.WriteLine("Durée du contrat invalide. Contrat non créé.");
            this.logement = null;
            return;
        }

        this.logement = logement;
        this.nombreJours = nombreJours;
        this.tarifJournalier = logement.CalculerLoyer();
        this.logement.Disponible = false;
    }

    public double CalculerMontantTotal()
    {
        if (logement == null) return 0;
        return tarifJournalier * nombreJours;
    }

    public void Afficher()
    {
        if (logement == null)
        {
            Console.WriteLine("Contrat invalide. Rien à afficher.");
            return;
        }

        Console.WriteLine("Contrat numéro : " + numero);
        Console.WriteLine(locataire);
        Console.WriteLine(logement);
        Console.WriteLine("Durée : " + nombreJours + " jours");
        Console.WriteLine("Tarif journalier : " + tarifJournalier + " euros");
        Console.WriteLine("Montant total : " + CalculerMontantTotal() + " euros");
    }
}