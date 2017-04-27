using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataTennis.kata.tennis;

namespace KataTennis
{
    class LancerJeu
    {        
        static void Main()
        {
            Tennis partieTennis = new Tennis();
            partieTennis.lancerLeJeuModeApplicationConsol();
            Console.Read();
        }        
    }
}
