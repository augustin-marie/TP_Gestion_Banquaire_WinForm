using System;

namespace GestionBancaire.Core
{
    public class CompteCourant : Compte
    {
        public double FraisDeTransfert { get; set; }
        public double SoldeMinimumAutorise { get; set; }

        public CompteCourant()
        {
            Console.WriteLine("Compte courant crée");
        }

        public CompteCourant(int numero, string libelleClient, double soldeMin)
        : base(numero, libelleClient)
        {
            this.SoldeMinimumAutorise = soldeMin;
            this.Solde = soldeMin;

            Console.WriteLine("Compte courant crée. Solde min: {0}", soldeMin);
        }

        ~CompteCourant()
        {
            Console.WriteLine("Compte courant détruit");
        }

        public override void Crediter(double montant)
        {
            this.Solde += montant;
        }

        public override bool Debiter(double montant)
        {
            // Si le montant est supérieur à la somme ou que le au solde minimum autorisé, le transfert n'est pas autorisé
            if (montant > this.Solde || (this.Solde - montant) < this.SoldeMinimumAutorise)
            {
                return false;
            }

            this.Solde -= montant;
            return true;
        }

        public bool Transfert(double montant, CompteCourant compte)
        {
            // Si le montant a pu être débité, alors l'autre compte est crédité
            if (this.Debiter(montant))
            {
                compte.Crediter(montant);
                return true;
            }

            return false;
        }

        public bool Transfert(double montant, CompteEpargne compte)
        {
            // Le transfert n'est pas possible si le montant esau solde minimum autorisé + les frais de transfert
            if (montant > this.Solde + this.FraisDeTransfert)
            {
                return false;
            }

            // Si le transfert a bien lieu, on débite aussi les frais de transfert et on crédite l'autre compte
            if (this.Debiter(montant))
            {
                this.Debiter(this.FraisDeTransfert);
                compte.Crediter(montant);
                return true;
            }

            return false;
        }
    }
}
