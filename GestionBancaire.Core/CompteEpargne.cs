using System;

namespace GestionBancaire.Core
{
    public class CompteEpargne : Compte
    {
        public double TauxInteret { get; set; }
        public double Plafond { get; set; }

        public CompteEpargne()
        {
            Console.WriteLine("Compte épargne crée");
        }

        public CompteEpargne(int numero, string libelleClient)
        : base(numero, libelleClient)
        {
            Console.WriteLine("Compte épargne avec nom et libellé crée");
        }

        public override void Crediter(double montant)
        {
            if (this.Solde + montant <= this.Plafond)
            {
                this.Solde += montant;
            }
        }

        public override bool Debiter(double montant)
        {
            if (montant > this.Solde)
            {
                return false;
            }

            this.Solde -= montant;
            return true;
        }

        public double CalculMontantInteret(int nombreAnnees)
        {
            return this.Solde * this.TauxInteret * nombreAnnees;
        }
    }
}
