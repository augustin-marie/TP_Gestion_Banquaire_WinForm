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
    public partial class OuvrirCompteForm : Form
    {
        public Banque banque { get; set; }
        public OuvrirCompteForm(Banque banque)
        {
            InitializeComponent();
            this.banque = banque;
        }


        private void btnValider_Click(object sender, EventArgs e)
        {
            //Verifications
            if (champsValides() == true)
            {
                if (radCourant.Checked == true)
                {
                    CompteCourant compte = new CompteCourant(int.Parse(inputNum.Text), inputLibelle.Text, double.Parse(inputSoldeMin.Text));
                    compte.FraisDeTransfert = double.Parse(inputFraiTransfert.Text);
                    compte.Solde = double.Parse(inputSolde.Text);
                    this.banque.ListeComptes.Add(compte);
                }
                else
                {
                    CompteEpargne compte = new CompteEpargne(int.Parse(inputNum.Text), inputLibelle.Text);
                    compte.TauxInteret = double.Parse(inputTxInteret.Text);
                    compte.Plafond = double.Parse(inputPlafond.Text);
                    compte.Solde = double.Parse(inputSolde.Text);
                    this.banque.ListeComptes.Add(compte);
                }
                this.Close();


            }
            
        }
        
        private bool champsValides()
        {
            List<string> listNumericInputs = new List<string>();
            listNumericInputs.Add(inputSolde.Text);
            if (radCourant.Checked == true)
            {
                listNumericInputs.Add(inputFraiTransfert.Text);
                listNumericInputs.Add(inputSoldeMin.Text);
            }
            else
            {
                listNumericInputs.Add(inputPlafond.Text);
            }
            
            foreach ( string inputValue in listNumericInputs)
            {
                if (double.TryParse(inputValue, out _) == false)
                {
                    MessageBox.Show("Un des champs numériques a une valeur non valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (radCourant.Checked == true)
            {
                if(double.Parse(inputSolde.Text) < double.Parse(inputSoldeMin.Text))
                {
                    MessageBox.Show("Le solde doit être supérieur au solde minimum", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                if (double.TryParse(inputTxInteret.Text, out _) == false)
                {
                    MessageBox.Show("Un des champs numériques a une valeur non valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (double.Parse(inputSolde.Text) > double.Parse(inputPlafond.Text))
                {
                    MessageBox.Show("Le solde doit être inférieur au plafond", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (double.Parse(inputPlafond.Text) > 100000 | double.Parse(inputPlafond.Text) < 0)
                {
                    MessageBox.Show("Le plafond doit être plus grand que 0 mais plus petit que 100 000", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (int.TryParse(inputNum.Text, out _) == false)
            {
                MessageBox.Show("Le numéro de compte doit être un chiffre entier positif", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(int.Parse(inputNum.Text) < 100000)
            {
                MessageBox.Show("Le numéro du compte doit être plus grand que 100 000", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

                if (string.IsNullOrEmpty(inputLibelle.Text)  == true)
            {
                MessageBox.Show("Le libelle du compte doit être renseigner", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        private void radEpargne_CheckedChanged(object sender, EventArgs e)
        {
            if (radCourant.Checked == true)
            {
                inputTxInteret.Enabled = false;
                inputPlafond.Enabled = false;
                inputFraiTransfert.Enabled = true;
                inputSoldeMin.Enabled = true;
            }
            else
            {
                inputTxInteret.Enabled = true;
                inputPlafond.Enabled = true;
                inputFraiTransfert.Enabled = false;
                inputSoldeMin.Enabled = false;
            }
        }
    }
}
