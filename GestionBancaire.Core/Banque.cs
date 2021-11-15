using System.Collections.Generic;
using System.ComponentModel;

namespace GestionBancaire.Core
{
    public class Banque
    {
        public string RaisonSociale { get; set; }
        public BindingList<Compte> ListeComptes { get; set; }

        public Banque()
        {
            this.ListeComptes = new BindingList<Compte>();
        }
    }
}
