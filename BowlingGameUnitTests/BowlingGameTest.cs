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
            rollMany(20, 0);
            Assert.AreEqual(0, g.score());
        }

        [TestMethod]
        public void testAllOnes()
        {
            rollMany(20, 1);
            Assert.AreEqual(20, g.score());
        }

        [TestMethod]
        public void testOneSpare()
        {
            g.roll(5);
            g.roll(5);
            g.roll(3);
            rollMany(17, 0);
            Assert.AreEqual(16, g.score());
        }

        [TestMethod]
        public void testAllStrikes()
        {
            for (int i = 0; i < 12; i++)
            {
                g.roll(10);
            }
            Assert.AreEqual(300, g.score());
        }

        private void rollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
            {
                g.roll(pins);
            }
        }
    }
}
