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
        Console.WriteLine("Surface jardin : " + surfaceJardin + " mcarrés");
    }

    public override double CalculerLoyer()
    {
        double loyer = base.CalculerLoyer();
        loyer += 10 * surfaceJardin; 
        return loyer;
    }
}