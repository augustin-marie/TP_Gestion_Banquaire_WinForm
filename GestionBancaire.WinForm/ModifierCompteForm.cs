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
    public partial class ModifierCompteForm : Form
    {
        public Compte compte { get; set; }


        public ModifierCompteForm(Compte compte)
        {
            InitializeComponent();

            this.compte = compte;

            if (compte is CompteCourant)
            {
                CompteCourant compteCourant = compte as CompteCourant;
                lbFraisDeTransfert.Visible = true;
                inputFraiTransfert.Visible = true;
                inputFraiTransfert.Text = compteCourant.FraisDeTransfert.ToString();
            }
            else
            {
                CompteEpargne compteEpargne = compte as CompteEpargne;
                lbTxInteret.Visible = true;
                inputTxInteret.Visible = true;
                inputTxInteret.Text = compteEpargne.TauxInteret.ToString();
            }
            
            inputLibelleCompte.Text = compte.LibelleClient;
            lbDetailCompte.Text = compte.ToString();
            this.Text = $"Modifier le compte n°{compte.Numero}";
        }



        private void buttonValider_Click(object sender, EventArgs e)
        {
            if (inputLibelleCompte.Text != "")
            {
                if (compte is CompteCourant)
                {
                    if (double.TryParse(inputFraiTransfert.Text, out _) == false)
                    {
                        MessageBox.Show("Le champ \"frai de transfert\" a une valeur non valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        CompteCourant compteCourant = compte as CompteCourant;
                        compteCourant.LibelleClient = inputLibelleCompte.Text;
                        compteCourant.FraisDeTransfert = double.Parse(inputFraiTransfert.Text);
                        this.Close();
                    }
                }
                else
                {
                    if (double.TryParse(inputTxInteret.Text, out _) == false)
                    {
                        MessageBox.Show("Le champ \"taux d'intérêt\" a une valeur non valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        CompteEpargne compteEpargne = compte as CompteEpargne;
                        compteEpargne.LibelleClient = inputLibelleCompte.Text;
                        compteEpargne.TauxInteret = double.Parse(inputTxInteret.Text);
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Le compte doit avoir un libelle.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
