using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection
{
    internal class Session
    {
        private int numero;
        private DateTime date;
        private int nbMax;
        private List<Participant> _Participant;

        public Session(int numeroSession, DateTime date, int nbMax)
        {
            this.numero = numeroSession;
            this.date = date;
            this.nbMax =nbMax;
           
        }
        public void ajouterParticipant(Participant p)
        {
            if (estPlein())
            {
                this._Participant.Add(p);
            }
            else
            {
                Console.WriteLine("C'EST PLEIN !!!!");
            }
        }

        public bool estPlein() 
        {
            if (this.nbMax > this._Participant.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int getnum()
        {
            return this.numero;
        }

        
    }
}
