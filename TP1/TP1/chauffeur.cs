using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    internal class chauffeur
    {
        private string Nom;
        private string Prenom;
        private int NumeroLicence;
        private bool EstDisponible;
        private string MissionActuelle;

        public chauffeur(string nom, string prenom, int numeroLicence, bool estDisponible, string missionActuelle)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.NumeroLicence = numeroLicence;
            this.EstDisponible = true;
            this.MissionActuelle = missionActuelle;
        }
        public void AfficherInfos()
        {
            Console.WriteLine("Nom :"+this.Nom);
            Console.WriteLine("prenom:"+this.Prenom);
            Console.WriteLine("Numéro de licence:"+this.NumeroLicence);
            Console.WriteLine("Est disponible:"+this.EstDisponible);
            Console.WriteLine("Est actuellement en mission:"+this.MissionActuelle);
        }

        public void Assignermission(string mission)
        {
            if (this.EstDisponible)
            {
                throw new Exception("le chauffeur est indisponible");
            }
            else
            {
                Console.WriteLine("le chauffeur est disponible");
            }
        }

        public void TerminerMission()
        {
            this.EstDisponible = true;

        }
        public void setnom(string nom)
        {
            this.Nom = nom;
        }
        public string getnom()
        {
            return this.Nom;
        }

        public void setprenom(string prenom)
        {
            this.Prenom = prenom;
        }
        public string getprenom()
        {
            return this.Prenom;
        }

        public void setmissionactuelle(string missionactuelle)
        {
            this.MissionActuelle = missionactuelle;
        }
        public string getmissionactuelle()
        {
            return this.MissionActuelle;
        }

        public void setnumerolicence(int numerolicence)
        {
            this.NumeroLicence = numerolicence;
        }
        public int getnumerolicence()
        {
            return this.NumeroLicence;
        }

        public void setestdisponible(bool estdisponible)
        {
            this.EstDisponible = estdisponible;
        }
        public bool getestdisponible()
        {
            return this.EstDisponible;
        }
    }
}