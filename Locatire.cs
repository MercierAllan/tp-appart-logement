class Locataire
{
    private int id;
    private string nom;
    private string telephone;

    public Locataire(int id, string nom, string telephone)
    {
        this.id = id;
        this.nom = nom;
        this.telephone = telephone;
    }
    public void Afficher()
    {
        Console.WriteLine("ID : " + id);
        Console.WriteLine("Nom : " + nom);
        Console.WriteLine("Téléphone : " + telephone);
    }
}
