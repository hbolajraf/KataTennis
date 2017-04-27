using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTennis.kata.tennis
{
    class Joueur
    {
        private string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        private string prenom;

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public int nbrPoint;

        public int NbrPoint
        {
            get { return nbrPoint; }
            set { nbrPoint = value; }
        }

        public Joueur() { }

    }
}
