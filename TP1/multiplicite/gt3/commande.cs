using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplicite
{
    internal class Commande
    {
        private int IdCommande;
        private List<LigneCommande> Lignes;
        private DateTime DateCommande;

        public Commande(int uneCommande, DateTime dateCommande)
        {
            this.DateCommande = dateCommande;
            this.IdCommande = uneCommande;
            this.Lignes = new List<LigneCommande>();

        }

        public void AjouterLigne(LigneCommande Lignes)
        { 
            this.Lignes.Add(Lignes);
        }

        public decimal calculerTotalcommande()
        {
            return LigneCommande.;
        }

    }
}
