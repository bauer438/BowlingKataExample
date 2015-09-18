using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingKataExample;

namespace BowlingGameUnitTests
{
    [TestClass]
    public class BowlingGameTest
    {
        [TestMethod]
        public void testGutterGame()
        {
            Game g = new Game();
            for (int i = 0; i < 20; i++)
            {
                g.roll(0);
            }
            Assert.AreEqual(0, g.score());
        }
    }
}
