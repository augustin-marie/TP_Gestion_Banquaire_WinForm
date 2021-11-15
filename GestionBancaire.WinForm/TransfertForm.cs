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
    public partial class TransfertForm : Form
    {
        public string TypeCompte { get; set; }

        public Compte compteSource { get; set; }

        public TransfertForm(Compte compteSource, Banque banque)
        {
            InitializeComponent();

            this.compteSource = compteSource;

            foreach (Compte compte in banque.ListeComptes)
            {
                if (compte != compteSource)
                {
                    selectCompteDestination.Items.Add(compte);
                }
            }

            lbCompteSourceName.Text = compteSource.ToString();
        }

        private void messageOperation(bool operationReussie)
        {
            if (operationReussie == true)
            {
                MessageBox.Show("L'operation de transfert c'est correctement effectuée.", "Succes", MessageBoxButtons.OK);

                this.Close();
            }
            else
            {
                MessageBox.Show("Un problème innatendu c'est produit.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            double montant = double.Parse(inputMontant.Text);

            if (selectCompteDestination.SelectedItem == default)
            {
                MessageBox.Show("Merci de choisir un compte de destination.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Compte a débiter

                // Cas ou le compte a débiter est un compte courant
                if (compteSource is CompteCourant)
                {
                    CompteCourant compteDebiteur = compteSource as CompteCourant;

                    //Cas ou le compte a créditer est un compte courant
                    if (selectCompteDestination.SelectedItem is CompteCourant)
                    {
                        CompteCourant compteCrediter = selectCompteDestination.SelectedItem as CompteCourant;
                        if (compteDebiteur.Solde - montant < compteDebiteur.SoldeMinimumAutorise)
                        {
                            MessageBox.Show("Le compte a débiter ne peut pas transférer autant.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        } else
                        {
                            bool operationReussie = compteDebiteur.Transfert(montant, compteCrediter);
                            messageOperation(operationReussie);
                        }

                    }

                    //Cas ou le compte a créditer est un compte épargne
                    else
                    {
                        CompteEpargne compteCrediter = selectCompteDestination.SelectedItem as CompteEpargne;
                        if (compteCrediter.Solde + montant > compteCrediter.Plafond)
                        {
                            MessageBox.Show("Le plafond de se compte ne permet pas de créditer autant.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (compteDebiteur.Solde - montant - compteDebiteur.FraisDeTransfert < compteDebiteur.SoldeMinimumAutorise)
                            {
                                MessageBox.Show("Le compte a débiter ne peut pas transférer autant 'en prennant en compte les frai de transfer).", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                bool operationReussie = compteDebiteur.Transfert(montant, compteCrediter);
                                messageOperation(operationReussie);
                            }
                        }
                    }
                }


                //Cas ou le compte a débiter est un compte epargne
                else
                {
                    //Comme la méthode transférer n'est pas implémentée dans CompteEpargne.cs j'ai interpréter sa comme "on ne peut pas transférer depuis un compte épargne"
                    //Puisque je n'était pas sûr, j'ai quand même mis toute la structure pour gérer ce cas la, j'ai juste mis une erreur au lieu de faire les derniers tests puis transférer
                    MessageBox.Show("On ne peut pas transferer depuis un compte épargne.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
    }
}
