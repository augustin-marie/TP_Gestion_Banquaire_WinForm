using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionBancaire.Core;

namespace GestionBancaire.WinForm
{
    public partial class CrediterCompteForm : Form
    {
        public string TypeCompte { get; set; }

        public Compte compte { get; set; }

        public CrediterCompteForm(Compte compte)
        {
            InitializeComponent();
            this.compte = compte;

            if (compte is CompteCourant){
                initCompteCourant(compte as CompteCourant);
            }
            else
            {
                initCompteEpargne(compte as CompteEpargne);
            }
        }


        public void initCompteCourant(CompteCourant compte)
        {
            TypeCompte = "courant";
            lbInfoCompte.Text = compte.ToString();

            lbTypeCompte.Text = "Compte courant";

            lbContraintes.Text = $"Solde minimum autorise : {compte.SoldeMinimumAutorise}";
        }

        public void initCompteEpargne(CompteEpargne compte)
        {
            TypeCompte = "epargne";
            lbInfoCompte.Text = compte.ToString();

            lbTypeCompte.Text = "Compte epargne";

            lbContraintes.Text = $"Solde maximum autorise : {compte.Plafond}";
        }


        private void btnValider_Click(object sender, EventArgs e)
        {
            if (double.TryParse(inputValue.Text, out _) == false | double.Parse(inputValue.Text) > 0)
            {
                if(TypeCompte == "courant")
                {
                    CompteCourant compteCourant = this.compte as CompteCourant;
                    compteCourant.Crediter(double.Parse(inputValue.Text));
                }
                else
                {
                    CompteEpargne compteEpargne = this.compte as CompteEpargne;
                    if (compteEpargne.Solde + double.Parse(inputValue.Text) <= compteEpargne.Plafond)
                    {
                        compteEpargne.Crediter(double.Parse(inputValue.Text));
                    }
                }
                MessageBox.Show($"Compte créditer de {inputValue.Text} €");
                this.Close();
            }
            else
            {
                MessageBox.Show("Montant saisi invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
