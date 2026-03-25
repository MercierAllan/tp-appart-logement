class Logement
{
    protected string reference;
    protected string adresse;
    protected int surface;
    protected double loyerBase;
    protected bool disponible;

    public Logement(string reference, string adresse, int surface, double loyerBase, bool disponible)
    {
        if (surface <= 0)
        {
            Console.WriteLine("Surface invalide, mise à 1 mcarrées par défaut.");
            surface = 1;
        }

        if (loyerBase < 0)
        {
            Console.WriteLine("Loyer invalide, mise à 0 euros par défaut.");
            loyerBase = 0;
        }

        this.reference = reference;
        this.adresse = adresse;
        this.surface = surface;
        this.loyerBase = loyerBase;
        this.disponible = disponible;
    }

    public virtual void Afficher()
    {
        Console.WriteLine("Référence : " + reference);
        Console.WriteLine("Adresse : " + adresse);
        Console.WriteLine("Surface : " + surface + " mcarrés");
        Console.WriteLine("Loyer de base : " + loyerBase + " euros");
        Console.WriteLine("Disponible : " + (disponible ? "Oui" : "Non"));
    }

    public virtual double CalculerLoyer()
    {
        return loyerBase;
    }
}