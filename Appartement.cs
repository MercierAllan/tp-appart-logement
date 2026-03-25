class Appartement : Logement
    {
        private int nombrePieces;

        public Appartement(string reference, string adresse, int surface, double loyerBase, bool disponible, int nombrePieces)
            : base(reference, adresse, surface, loyerBase, disponible)
        {
            if (nombrePieces < 1)
            {
                Console.WriteLine("Nombre de pièces invalide, mise à 1 par défaut.");
                nombrePieces = 1;
            }

            this.nombrePieces = nombrePieces;
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine("Nombre de pièces : " + nombrePieces);
        }
    }