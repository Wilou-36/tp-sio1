using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotèque_const
{
    internal class Livre
    {
        private string titre;
        private Auteur _auteur;
        private int anneePublication;

        public Livre(string untitre, Auteur unauteur, int uneanneePublication)
        {
            this.titre = untitre;
            _auteur = unauteur;
            this.anneePublication = uneanneePublication;
            nombreTotalLivres++;
        }

        public const int dureeEmpruntMax = 28;
        public static int nombreTotalLivres = 0;
        public static int nombreLivresEmprunt = 0; 

        public string getLivre()
        {
            return this.titre;
        }

        public void Emprunt()
        {
            nombreLivresEmprunt++;
            Console.WriteLine("aucun livre n'est actuellement en votre possession");
        }

        public void Rendre()
        {
            nombreLivresEmprunt--;
            Console.WriteLine("le livre est belle et bien rendu");
        }

        public void afficherStatiques()
        {
            Console.WriteLine("il y a" + nombreTotalLivres + "livre ");
            Console.WriteLine("tu as" + nombreLivresEmprunt + "en ta possession");
        }
    }
}
