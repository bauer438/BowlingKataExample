using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingKataExample;

namespace BowlingGameUnitTests
{
    [TestClass]
    public class BowlingGameTest
    {
        private Game g;

        [TestInitialize()]
        public void Initialize()
        {
            g = new Game();
        }

        [TestMethod]
        public void testGutterGame()
        {
            for (int i = 0; i < 20; i++)
            {
                g.roll(0);
            }
            Assert.AreEqual(0, g.score());
        }

        [TestMethod]
        public void testAllOnes()
        {
            for (int i = 0; i < 20; i++)
            {
                g.roll(1);
            }
            Assert.AreEqual(20, g.score());
        }

        //[TestMethod]
        //public void testAllStrikes()
        //{
        //    for (int i = 0; i < 12; i++)
        //    {
        //        g.roll(10);
        //    }
        //    Assert.AreEqual(300, g.score());
        //}
    }
}
