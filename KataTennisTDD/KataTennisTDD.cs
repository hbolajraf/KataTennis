using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KataTennis.kata.tennis;

namespace KataTennisTDD
{
    [TestClass]
    public class KataTennisTDD
    {
        [TestMethod]
        public void KataTennisTestMethod()
        {
            Tennis partieTennis = new Tennis();
            partieTennis.lancerLeJeuModeTDD();

            //Cas de tests
            Assert.AreEqual(partieTennis.getScore(0, 1), "Score : 0 - 15");
            Assert.AreEqual(partieTennis.getScore(0, 2), "Score : 0 - 30");
            Assert.AreEqual(partieTennis.getScore(1, 2), "Score : 15 - 30");
            Assert.AreEqual(partieTennis.getScore(2, 2), "Score : 30 - 30");
            Assert.AreEqual(partieTennis.getScore(2, 3), "Score : 30 - 40");
            Assert.AreEqual(partieTennis.getScore(3, 3), "Deuce");
            Assert.AreEqual(partieTennis.getScore(3, 4), "Avantage pour : FEDERER");
            Assert.AreEqual(partieTennis.getScore(3, 5), "Match pour : FEDERER");

            Assert.AreEqual(partieTennis.getScore(0, 0), "Score : 0 - 0");
            Assert.AreEqual(partieTennis.getScore(1, 0), "Score : 15 - 0");
            Assert.AreEqual(partieTennis.getScore(2, 0), "Score : 30 - 0");
            Assert.AreEqual(partieTennis.getScore(2, 1), "Score : 30 - 15");
            Assert.AreEqual(partieTennis.getScore(3, 2), "Score : 40 - 30");
            Assert.AreEqual(partieTennis.getScore(4, 1), "Match pour : NADAL");
            Assert.AreEqual(partieTennis.getScore(4, 3), "Avantage pour : NADAL");
            Assert.AreEqual(partieTennis.getScore(6, 6), "Tie-Break");
            Assert.AreEqual(partieTennis.getScore(8, 6), "Match pour : NADAL");           
        }
    }
}
