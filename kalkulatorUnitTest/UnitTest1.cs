using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Kalkulator;

namespace kalkulatorUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        Calculator osztaly = new Calculator();

        [TestMethod]
        public void osszeadR()
        {
            int varteredmeny = 5;

            int kapotteredmeny = Kalkulator.Calculator.szamol(15, 5, '+');

            Assert.AreNotEqual(kapotteredmeny, varteredmeny);
        }

        [TestMethod]
        public void osszeadJ()
        {
            int varteredmeny = 20;

            int kapotteredmeny = Kalkulator.Calculator.szamol(15, 5, '+');

            Assert.AreEqual(kapotteredmeny, varteredmeny);
        }

        [TestMethod]
        public void kivonR()
        {
            int varteredmeny = 10;

            int kapotteredmeny = Kalkulator.Calculator.szamol(5, 5, '-');

            Assert.AreNotEqual(kapotteredmeny, varteredmeny);
        }

        [TestMethod]
        public void kivonJ()
        {
            int varteredmeny = 10;

            int kapotteredmeny = Kalkulator.Calculator.szamol(15, 5, '-');

            Assert.AreEqual(varteredmeny, kapotteredmeny);
        }

        [TestMethod]
        public void szorozR()
        {
            int varteredmeny = 15;

            int kapotteredmeny = Kalkulator.Calculator.szamol(2, 5, '*');

            Assert.AreNotEqual(kapotteredmeny, varteredmeny);
        }

        [TestMethod]
        public void szorozJ()
        {
            int varteredmeny = 10;

            int kapotteredmeny = Kalkulator.Calculator.szamol(2, 5, '*');

            Assert.AreEqual(kapotteredmeny, varteredmeny);
        }

        [TestMethod]
        public void osztR()
        {
            int varteredmeny = 3;

            int kapotteredmeny = Kalkulator.Calculator.szamol(10, 5, '/');

            Assert.AreNotEqual(kapotteredmeny, varteredmeny);
        }

        [TestMethod]
        public void osztJ()
        {
            int varteredmeny = 2;

            int kapotteredmeny = Kalkulator.Calculator.szamol(10, 5, '/');

            Assert.AreEqual(kapotteredmeny, varteredmeny);
        }

        [TestMethod]
        public void osztasNullaval()
        {
            string varteredmeny = "nem lehet";

            string kapotteredmeny;

            using (var szoveg = new StringWriter())
            {
                Console.SetOut(szoveg);

                Kalkulator.Calculator.szamol(10, 0, '/');

                kapotteredmeny = szoveg.ToString().Trim();
            }

            Assert.AreNotEqual(kapotteredmeny, varteredmeny);
        }
    }
}
