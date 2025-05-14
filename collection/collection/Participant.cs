using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection
{
    internal class Participant
    {
        private string nom;
        private string prenom;
        private int anciennete;
        private List<Session> sessions;

        public Participant(string nom, string prenom, int anciennete)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.anciennete = anciennete;
        }

        public List<Session> getChoixSession()
        {
            return this.sessions;
        }

        public List<Session> setLaSession()
        {
            this.sessions = new List<Session>();
        }

    }
}
