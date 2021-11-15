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
    public partial class DebiterCompteForm : Form
    {
        public string TypeCompte { get; set; }

        public Compte compte { get; set; }

        public DebiterCompteForm(Compte compte)
        {
            InitializeComponent();
            this.compte = compte;

            if (compte is CompteCourant)
            {
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



        private void btnValider_Click_1(object sender, EventArgs e)
        {
            if (double.TryParse(inputValue.Text, out _) == false | double.Parse(inputValue.Text) > 0)
            {
                if (TypeCompte == "courant")
                {
                    CompteCourant compteCourant = this.compte as CompteCourant;
                    if (compteCourant.Solde - double.Parse(inputValue.Text) >= compteCourant.SoldeMinimumAutorise)
                        compteCourant.Debiter(double.Parse(inputValue.Text));
                }
                else
                {
                    CompteEpargne compteEpargne = this.compte as CompteEpargne;
                    if (compteEpargne.Solde - double.Parse(inputValue.Text) >= 0)
                    {
                        compteEpargne.Debiter(double.Parse(inputValue.Text));
                    }
                }
                MessageBox.Show($"Compte débiter de {inputValue.Text} €");
                this.Close();
            }
            else
            {
                MessageBox.Show("Montant saisi invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
