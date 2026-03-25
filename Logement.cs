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
                throw new ArgumentException("La surface doit être strictement positive.");
            }

            if (loyerBase < 0)
            {
                throw new ArgumentException("Le loyer ne peut pas être négatif.");
            }

            this.reference = reference;
            this.adresse = adresse;
            this.surface = surface;
            this.loyerBase = loyerBase;
            this.disponible = disponible;
        }

        public void Afficher()
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