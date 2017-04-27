using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTennis.kata.tennis
{
    public class Tennis
    {
        private Joueur joueur1;
        private Joueur joueur2;

        public void lancerLeJeuModeApplicationConsol()
        {
            initialiserJoueur();
            randomSetsParParties(joueur1, joueur2);
        }

        public void lancerLeJeuModeTDD()
        {
            initialiserJoueur();
        }

        public string getScore(int pointsJoueur1, int pointsJoueur2)
        {
            joueur1.nbrPoint = pointsJoueur1;
            joueur2.nbrPoint = pointsJoueur2;
            return afficherScore(joueur1, joueur2);
        }

        private void randomSetsParParties(Joueur joueur1, Joueur joueur2)
        {
            //Random rand = new Random();

            //0 - 0
            joueur1.nbrPoint = 0;
            joueur2.nbrPoint = 0;
            Console.WriteLine(afficherScore(joueur1, joueur2));

            //0 - 15
            joueur1.nbrPoint = 0;
            joueur2.nbrPoint = 1;
            Console.WriteLine(afficherScore(joueur1, joueur2));

            //0 - 30
            joueur1.nbrPoint = 0;
            joueur2.nbrPoint = 2;
            Console.WriteLine(afficherScore(joueur1, joueur2));

            //15 - 30
            joueur1.nbrPoint = 1;
            joueur2.nbrPoint = 2;
            Console.WriteLine(afficherScore(joueur1, joueur2));

            //30 - 30
            joueur1.nbrPoint = 2;
            joueur2.nbrPoint = 2;
            Console.WriteLine(afficherScore(joueur1, joueur2));

            //30 - 40
            joueur1.nbrPoint = 2;
            joueur2.nbrPoint = 3;
            Console.WriteLine(afficherScore(joueur1, joueur2));

            //deuce
            joueur1.nbrPoint = 3;
            joueur2.nbrPoint = 3;
            Console.WriteLine(afficherScore(joueur1, joueur2));

            //Avantage pour : joueur 2(FEDERER)
            joueur1.nbrPoint = 3;
            joueur2.nbrPoint = 4;
            Console.WriteLine(afficherScore(joueur1, joueur2));

            //Match pour : joueur 2(FEDERER)
            joueur1.nbrPoint = 3;
            joueur2.nbrPoint = 5;
            Console.WriteLine(afficherScore(joueur1, joueur2));

            //0 - 0
            joueur1.nbrPoint = 0;
            joueur2.nbrPoint = 0;
            Console.WriteLine(afficherScore(joueur1, joueur2));

            //15 - 0
            joueur1.nbrPoint = 1;
            joueur2.nbrPoint = 0;
            Console.WriteLine(afficherScore(joueur1, joueur2));

            //30 - 0
            joueur1.nbrPoint = 2;
            joueur2.nbrPoint = 0;
            Console.WriteLine(afficherScore(joueur1, joueur2));

            //30 - 15
            joueur1.nbrPoint = 2;
            joueur2.nbrPoint = 1;
            Console.WriteLine(afficherScore(joueur1, joueur2));

            //40 - 30
            joueur1.nbrPoint = 3;
            joueur2.nbrPoint = 1;
            Console.WriteLine(afficherScore(joueur1, joueur2));

            //Match pour : joueur 1(NADAL)
            joueur1.nbrPoint = 4;
            joueur2.nbrPoint = 1;
            Console.WriteLine(afficherScore(joueur1, joueur2));

            //Avantage pour : joueur 1(NADAL)
            joueur1.nbrPoint = 4;
            joueur2.nbrPoint = 3;
            Console.WriteLine(afficherScore(joueur1, joueur2));

            //Tie-Break
            joueur1.nbrPoint = 6;
            joueur2.nbrPoint = 6;
            Console.WriteLine(afficherScore(joueur1, joueur2));

            //Match pour : joueur 1(NADAL)
            joueur1.nbrPoint = 8;
            joueur2.nbrPoint = 6;
            Console.WriteLine(afficherScore(joueur1, joueur2));
        }

        private string afficherScore(Joueur joueur1, Joueur joueur2)
        {
            string resultat = "Score : " + score(joueur1.NbrPoint) + " - " + score(joueur2.NbrPoint);

            //Deuce
            if ((joueur1.NbrPoint >= 3 && joueur2.NbrPoint >= 3) && (joueur1.NbrPoint == joueur2.NbrPoint))
                resultat = "Deuce";

            //Tie-Break
            if ((joueur1.NbrPoint >= 6 && joueur2.NbrPoint >= 6) && (joueur1.NbrPoint == joueur2.NbrPoint))
                resultat = "Tie-Break";

            //Si on a deux points de différences
            if ((joueur1.NbrPoint > 3 || joueur2.NbrPoint > 3)
                && (joueur1.NbrPoint == 0 || joueur2.NbrPoint == 0))
                resultat = "Match pour : " + (joueur1.NbrPoint > joueur2.NbrPoint ? joueur1.Nom : joueur2.Nom);

            if ((joueur1.NbrPoint > 3 || joueur2.NbrPoint > 3)
                && (joueur1.NbrPoint >= joueur2.NbrPoint + 2
                || joueur2.NbrPoint >= joueur1.NbrPoint + 2))
                resultat = "Match pour : " + (joueur1.NbrPoint > joueur2.NbrPoint ? joueur1.Nom : joueur2.Nom);

            if ((joueur1.NbrPoint >= 3 && joueur2.NbrPoint >= 3)
                && (joueur1.NbrPoint >= joueur2.NbrPoint + 2
                || joueur2.NbrPoint >= joueur1.NbrPoint + 2))
                resultat = "Match pour : " + (joueur1.NbrPoint > joueur2.NbrPoint ? joueur1.Nom : joueur2.Nom);

            if ((joueur1.NbrPoint >= 3 && joueur2.NbrPoint >= 3)
                 && (joueur1.NbrPoint == joueur2.NbrPoint + 1 || joueur2.NbrPoint == joueur1.NbrPoint + 1))
                resultat = "Avantage pour : " + (joueur1.NbrPoint > joueur2.NbrPoint ? joueur1.Nom : joueur2.Nom);

            return resultat;
        }

        private void initialiserJoueur()
        {
            joueur1 = new Joueur();
            joueur1.Nom = "NADAL";
            joueur1.Prenom = "Rafael";
            joueur1.Age = 30;

            joueur2 = new Joueur();
            joueur2.Nom = "FEDERER";
            joueur2.Prenom = "Roger";
            joueur2.Age = 35;
        }

        private string score(int point)
        {
            switch (point)
            {
                case 0: return "0";
                case 1: return "15";
                case 2: return "30";
                case 3: return "40";
                default: return "";
            }
        }
    }
}
