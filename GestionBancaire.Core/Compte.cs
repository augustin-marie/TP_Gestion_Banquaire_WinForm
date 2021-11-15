using System;

namespace GestionBancaire.Core
{
    public abstract class Compte
    {
        public int Numero { get; set; }
        public string LibelleClient { get; set; }
        public double Solde { get; set; }

        protected Compte()
        {
            Console.WriteLine("Compte crée");
        }

        protected Compte(int numero, string libelleClient)
        {
            this.Numero = numero;
            this.LibelleClient = libelleClient;

            Console.WriteLine("Compte crée. Numéro: {0}, Libellé: {1}", numero, libelleClient);
        }

        ~Compte()
        {
            Console.WriteLine("Compte détruit");
        }

        public override string ToString()
        {
            string typeCompte = "non-spécifié";
            if (this is CompteCourant)
            {
                typeCompte = "courant";
            }
            else if(this is CompteEpargne)
            {
                typeCompte = "epargne";
            }
            return $"Compte {typeCompte} n° {Numero} – {LibelleClient} – Solde : {Solde}€";
        }

        public abstract void Crediter(double montant);
        public abstract bool Debiter(double montant);
    }
}
