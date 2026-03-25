class Maison : Logement
{
    private int surfaceJardin;

    public Maison(string reference, string adresse, int surface, double loyerBase, bool disponible, int surfaceJardin)
        : base(reference, adresse, surface, loyerBase, disponible)
    {
        if (surfaceJardin < 0)
        {
            Console.WriteLine("Surface du jardin invalide, mise à 0.");
            surfaceJardin = 0;
        }
        this.surfaceJardin = surfaceJardin;
    }

    public override void Afficher()
    {
        base.Afficher();
        Console.WriteLine("Surface jardin : " + surfaceJardin + " mcarés");
    }

    public override double CalculerLoyer()
    {
        return base.CalculerLoyer() + 10 * surfaceJardin;
    }

    public override string ToString()
    {
        return base.ToString() + " - Jardin: " + surfaceJardin + " mcarés";
    }
}