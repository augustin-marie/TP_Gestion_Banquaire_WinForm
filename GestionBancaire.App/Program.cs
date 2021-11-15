using System;
using System.Linq;
using GestionBancaire.Core;

namespace GestionBancaire.Core
{
    class Program
    {
        private const double FraisTransfert = 5;
        private const double Plafond = 20000;
        private const double TauxInteret = 0.5 / 100;

        static void Main(string[] args)
        {
            var banque = new Banque();

            Console.WriteLine("Entrez le nom de la banque :");
            var nomBanque = Console.ReadLine();

            banque.RaisonSociale = nomBanque;

            string action;

            do
            {
                Console.Clear();
                Console.WriteLine("BANQUE: {0}", banque.RaisonSociale);
                Console.WriteLine("--------------------------------------------------");

                Console.WriteLine("[1] Voir les comptes");
                Console.WriteLine("[2] Ouvrir un compte courant");
                Console.WriteLine("[3] Ouvrir un compte épargne");
                Console.WriteLine("[4] Calculer le montant des intérêts");
                Console.WriteLine("(vide): Fermer");

                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Indiquez votre action :");

                action = Console.ReadLine();
                Console.Clear();

                switch (action)
                {
                    case "1":
                        VoirLesComptes(banque);
                        break;
                    case "2":
                        OuvrirCompteCourant(banque);
                        break;
                    case "3":
                        OuvrirCompteEpargne(banque);
                        break;
                    case "4":
                        CalculMontantInterets(banque);
                        break;
                }

                Console.ReadLine();
            } while (!string.IsNullOrWhiteSpace(action));
        }

        private static void VoirLesComptes(Banque banque)
        {
            Console.WriteLine("LISTE DES COMPTES OUVERTS - {0}", banque.RaisonSociale);
            Console.WriteLine("--------------------------------------------------");

            var compteSelectionne = ListerEtSelectionnerCompte(banque);
            Console.WriteLine("--------------------------------------------------");
            AfficherActionsCompte(banque, compteSelectionne);
        }

        private static Compte ListerEtSelectionnerCompte(Banque banque)
        {
            int indexCompte;

            do
            {
                for (var i = 0; i < banque.ListeComptes.Count; i++)
                {
                    var compte = banque.ListeComptes[i];
                    Console.WriteLine("[{0}] {1} N°{2} - {3} - Solde: {4}EUR", i, compte.GetType().Name, compte.Numero, compte.LibelleClient, compte.Solde);
                }

                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Sélectionnez un compte :");
            } while (!int.TryParse(Console.ReadLine(), out indexCompte) || indexCompte < 0 || indexCompte >= banque.ListeComptes.Count);

            return banque.ListeComptes[indexCompte];
        }

        private static void AfficherActionsCompte(Banque banque, Compte compteSelectionne)
        {
            string action;

            do
            {
                Console.Clear();
                Console.WriteLine("Compte sélectionné: {0} N°{1} - {2} - Solde: {3}EUR",
                                    compteSelectionne.GetType().Name, compteSelectionne.Numero, compteSelectionne.LibelleClient, compteSelectionne.Solde);

                Console.WriteLine("[1] Créditer");

                if (compteSelectionne is CompteCourant)
                {
                    Console.WriteLine("[2] Transférer vers un autre compte");
                }

                Console.WriteLine("(vide): Fermer");

                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Indiquez votre action :");

                action = Console.ReadLine();

                switch (action)
                {
                    case "1":
                        Crediter(compteSelectionne);
                        break;
                    case "2" when compteSelectionne is CompteCourant courant:
                        Transfert(banque, courant);
                        break;
                }
            } while (!string.IsNullOrWhiteSpace(action));
        }

        private static void Crediter(Compte compte)
        {
            Console.WriteLine("CREDITER UN COMPTE - N°{0} - {1}", compte.Numero, compte.LibelleClient);
            Console.WriteLine("--------------------------------------------------");

            double montant;

            do
            {
                Console.WriteLine("Entrez le montant à créditer :");
            } while (!double.TryParse(Console.ReadLine(), out montant));

            compte.Crediter(montant);
        }

        private static void Transfert(Banque banque, CompteCourant source)
        {
            Console.WriteLine("TRANSFERT VERS UN AUTRE COMPTE - N°{0} - {1}", source.Numero, source.LibelleClient);
            Console.WriteLine("--------------------------------------------------");

            var destination = ListerEtSelectionnerCompte(banque);

            double montant;

            do
            {
                Console.WriteLine("Entrez le montant à transférer :");
            } while (!double.TryParse(Console.ReadLine(), out montant));

            switch (destination)
            {
                case CompteEpargne epargne when source.Transfert(montant, epargne):
                    Console.WriteLine("Transfert vers compte épargne réussi.");
                    break;
                case CompteCourant courant when source.Transfert(montant, courant):
                    Console.WriteLine("Transfert vers compte courant réussi.");
                    break;
                default:
                    Console.WriteLine("Transfert échoué");
                    break;
            }
        }

        private static void OuvrirCompteCourant(Banque banque)
        {
            Console.WriteLine("OUVRIR UN COMPTE COURANT - {0}", banque.RaisonSociale);
            Console.WriteLine("--------------------------------------------------");

            var random = new Random();
            var numero = random.Next(100000, 999999);

            Console.WriteLine("Entrez le nom du client :");
            var libelleClient = Console.ReadLine();

            double soldeMin;

            do
            {
                Console.WriteLine("Entrez le solde minimum du compte :");
            } while (!double.TryParse(Console.ReadLine(), out soldeMin));

            var compte = new CompteCourant(numero, libelleClient, soldeMin);
            compte.FraisDeTransfert = FraisTransfert;
            banque.ListeComptes.Add(compte);
        }

        private static void OuvrirCompteEpargne(Banque banque)
        {
            Console.WriteLine("OUVRIR UN COMPTE EPARGNE - {0}", banque.RaisonSociale);
            Console.WriteLine("--------------------------------------------------");

            var random = new Random();
            var numero = random.Next(100000, 999999);

            Console.WriteLine("Entrez le nom du client :");
            var libelleClient = Console.ReadLine();

            var compte = new CompteEpargne(numero, libelleClient);
            compte.TauxInteret = TauxInteret;
            compte.Plafond = Plafond;

            banque.ListeComptes.Add(compte);
        }

        private static void CalculMontantInterets(Banque banque)
        {
            Console.WriteLine("CALCUL MONTANTS INTERETS - {0}", banque.RaisonSociale);
            Console.WriteLine("--------------------------------------------------");

            int nombreAnnees;

            do
            {
                Console.WriteLine("Entrez le nombre d'années pour le calcul :");
            } while (!int.TryParse(Console.ReadLine(), out nombreAnnees));

            foreach (var compte in banque.ListeComptes.Where(compte => compte is CompteEpargne).Cast<CompteEpargne>())
            {
                var montantCumule = compte.CalculMontantInteret(nombreAnnees);

                Console.WriteLine("N°{0} - {1} - Solde actuel: {2}EUR - Tx {3}% => Intérêts gagnés au bout de {4} années: {5}EUR",
                    compte.Numero, compte.LibelleClient, compte.Solde, compte.TauxInteret, nombreAnnees, montantCumule);
            }
        }
    }
}
