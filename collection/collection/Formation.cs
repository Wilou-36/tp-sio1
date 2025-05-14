using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection
{
    internal class Formation
    {
        private string _code;
        private string _libelle;
        private List<Participant> _participant;
        private List<Session> _session;

        public Formation(string acode, string alibelle)
        {
            this._code = acode;  
            this._libelle = alibelle;
            this._participant = new List<Participant>();
            this._session = new List<Session>();
        }

        public void AffecteParticipant(Participant p, int numeroSession)
        {
            // Rechercher la session correspondante dans la liste des sessions
            for (int i = 0; i < this._session.Count; i++)
            {
                // Vérifier si le numéro de session correspond
                if (numeroSession == this._session[i].getnum())
                {
                    Session session = this._session[i]; // Initialiser la session trouvée

                    // Vérifier si la session n'est pas pleine
                    if (!session.estPlein())
                    {
                        // Ajouter le participant si la session existe et n'est pas pleine
                        session.ajouterParticipant(p);
                        return; // Quitter la méthode après avoir ajouté le participant
                    }
                    else
                    {
                        Console.WriteLine("Session pleine.");
                        return; // Quitter la méthode
                    }
                }
            }

            // Si aucune session correspondante n'est trouvée
            Console.WriteLine("Session introuvable.");
        }
    }
}
