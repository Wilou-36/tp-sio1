using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_decouvert
{
    internal class voiture
    {
        private string Marque;
        private string Couleur;
        private string Matricule;
        private float Chevaux;


        public voiture(string unemarque, string unecouleur,string unmatricule, float deschevaux)
        {
            this.Marque = unemarque;
            this.Couleur = unecouleur;
            this.Matricule = unmatricule;
            this.Chevaux = deschevaux;
        }

        public voiture(string unmatricule)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }
       
        public voiture(string matricule)
        {
            this.Matricule = matricule;
        }
        


        public void setmarque(string unemarque)
        {
            this.Marque = unemarque;
        }
        public string getmarque()
        {
            return this.Marque;
        }

        
        public void setcouleur(string unecouleur)
        {
            this.Couleur = unecouleur;
        }
        public string getcouleur()
        { 
            return this.Couleur; 
        }

        
        public void setmatricule(string unmatricule)
        {
            this.Matricule = unmatricule;
        }
        public string getmatricule()
        {
            return this.Matricule;
        }

        public void setchevaux(float deschevaux)
        {
            this.Chevaux = deschevaux;
        }
        public float getchevaux()
        {
            return this.Chevaux;

        }

        public void AfficherInfos()
        {
            Console.WriteLine("Marque:" + this.Marque);
            Console.WriteLine("couleur:" + this.Couleur);
            Console.WriteLine("Couleur:" + this.Matricule);
            Console.WriteLine("nombre de chevaux:" + this.Chevaux);
        }

        public void  Aug_chevaux(int nb_ajouter)
        {
            int res = this.Chevaux += nb_ajouter;
            this.setchevaux(res);
            return res;
        }

    }
}
