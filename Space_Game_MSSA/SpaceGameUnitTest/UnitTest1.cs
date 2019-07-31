using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Space_Game_MSSA;

namespace SpaceGameUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Human player = new Human();
            player.gold = 100;
            Assert.AreEqual(70, player.gold);
        }

    }
}
