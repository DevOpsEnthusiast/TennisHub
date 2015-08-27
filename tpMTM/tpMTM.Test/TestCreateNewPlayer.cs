using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using tpMTM.DTO;
using tpMTM.DAL;
using tpMTM.BO;

namespace tpMTM.Tests
{
    [TestClass]
    public class TestCreateNewPlayer
    {
        [TestMethod]
        public void TestCreateNew()
        {
            PlayerBO player = new PlayerBO();
            player.AddPlayer("Kei Nishikori", "Japan", "", "");
            Assert.IsTrue(player.GetPlayerByName("Kei Nishikori").IsActive);
        }
    }
}
