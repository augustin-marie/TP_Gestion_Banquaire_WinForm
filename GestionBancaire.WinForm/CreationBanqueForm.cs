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
    public partial class CreationBanqueForm : Form
    {
        public CreationBanqueForm()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(inputBanque.Text))
            {
                Banque banque = new Banque();
                banque.RaisonSociale = inputBanque.Text;

                ListeComptesForm form = new ListeComptesForm(banque);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Veuillez saisir le nom", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
