class Logement
    {
        protected string reference;
        protected string adresse;
        protected int surface;
        protected double loyerBase;
        protected bool disponible;

        public Logement(string reference, string adresse, int surface, double loyerBase, bool disponible)
        {
            this.reference = reference;
            this.adresse = adresse;

            if (surface <= 0)
            {
                Console.WriteLine("Surface invalide, mise à 1 mcarrés par défaut.");
                this.surface = 1;
            }
            else
            {
                this.surface = surface;
            }

            if (loyerBase < 0)
            {
                Console.WriteLine("Loyer invalide, mise à 0 € par défaut.");
                this.loyerBase = 0;
            }
            else
            {
                this.loyerBase = loyerBase;
            }

            this.disponible = disponible;
        }

        public virtual void Afficher()
        {
            Console.WriteLine("Référence : " + reference);
            Console.WriteLine("Adresse : " + adresse);
            Console.WriteLine("Surface : " + surface + " mcarrés");
            Console.WriteLine("Loyer : " + loyerBase + " euros");
            Console.WriteLine("Disponible : " + (disponible ? "Oui" : "Non"));
        }

        public virtual double CalculerLoyer()
        {
            return loyerBase;
        }
    }
