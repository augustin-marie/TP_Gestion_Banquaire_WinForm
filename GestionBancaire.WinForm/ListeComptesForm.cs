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
    public partial class ListeComptesForm : Form
    {
        public Banque banque { get; set; }

        public ListeComptesForm(Banque banque)
        {
            InitializeComponent();
            this.Text = banque.RaisonSociale;
            this.Refresh();

            this.banque = banque;

            lbComptes.DataSource = this.banque.ListeComptes;

        }


        private void btnAjouter_Click(object sender, EventArgs e)
        {
            OuvrirCompteForm form = new OuvrirCompteForm(banque);
            form.ShowDialog();
        }

        private void btnCrediter_Click(object sender, EventArgs e)
        {
            if (lbComptes.SelectedItem != null)
            {
                CrediterCompteForm form = new CrediterCompteForm(banque.ListeComptes[lbComptes.SelectedIndex]);
                form.ShowDialog();
                banque.ListeComptes.ResetBindings();
            }
        }

        private void btnDebiter_Click(object sender, EventArgs e)
        {
            if (lbComptes.SelectedItem != null)
            {
                DebiterCompteForm form = new DebiterCompteForm(banque.ListeComptes[lbComptes.SelectedIndex]);
                form.ShowDialog();
                banque.ListeComptes.ResetBindings();
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (lbComptes.SelectedItem != null)
            {
                var confirmResult = MessageBox.Show("Êtes vous sûr de vouloir supprimer le compte sélectionner ?", "Confirmer la suppression", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    banque.ListeComptes.Remove(lbComptes.SelectedItem as Compte);
                }
            }
        }

        private void btnTransferer_Click(object sender, EventArgs e)
        {
            if (lbComptes.SelectedItem != null)
            {
                TransfertForm form = new TransfertForm(banque.ListeComptes[lbComptes.SelectedIndex], banque);
                form.ShowDialog();
                banque.ListeComptes.ResetBindings();
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (lbComptes.SelectedItem != null)
            {
                if (banque.ListeComptes[lbComptes.SelectedIndex] is CompteCourant)
                {
                    ModifierCompteForm form = new ModifierCompteForm(banque.ListeComptes[lbComptes.SelectedIndex] as CompteCourant);
                    form.ShowDialog();
                }
                else
                {
                    ModifierCompteForm form = new ModifierCompteForm(banque.ListeComptes[lbComptes.SelectedIndex] as CompteEpargne);
                    form.ShowDialog();
                }
                banque.ListeComptes.ResetBindings();
            }
        }
    }
}
