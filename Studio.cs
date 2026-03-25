class Studio : Logement
{
    private bool meuble;

    public Studio(string reference, string adresse, int surface, double loyerBase, bool disponible, bool meuble)
        : base(reference, adresse, surface, loyerBase, disponible)
    {
        this.meuble = meuble;
    }

    public override void Afficher()
    {
        base.Afficher();
        Console.WriteLine("Meublé : " + (meuble ? "Oui" : "Non"));
    }

    public override double CalculerLoyer()
    {
        double loyer = base.CalculerLoyer();
        if (meuble)
            loyer += 50;
        return loyer;
    }

    public override string ToString()
    {
        return base.ToString() + " - Meublé: " + (meuble ? "Oui" : "Non");
    }
}