using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MinimumMaximum;

namespace MinMaxUt
{
    [TestClass]
    public class UnitTest1
    {
        MinMax minmaxos = new MinMax();

        [TestMethod]
        public void minimumJo()
        {
            int varteredmeny = 3;

            int kapotteredmeny = minmaxos.mini();

            Assert.AreEqual(varteredmeny, kapotteredmeny);
        }

        [TestMethod]
        public void minimumRossz()
        {
            int varteredmeny = 5;

            int kapotteredmeny = minmaxos.minValasztoNONRND();

            Assert.AreNotEqual(varteredmeny, kapotteredmeny);
        }

        [TestMethod]
        public void maximumJo()
        {
            int varteredmeny = 199;

            int kapotteredmeny = minmaxos.maxValasztoNONRND();

            Assert.AreEqual(varteredmeny, kapotteredmeny);
        }

        [TestMethod]
        public void maximumRossz()
        {
            int varteredmeny = 198;

            int kapotteredmeny = minmaxos.maxValasztoNONRND();

            Assert.AreNotEqual(varteredmeny, kapotteredmeny);
        }
    }
}