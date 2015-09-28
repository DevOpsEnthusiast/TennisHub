using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using tpMTM.DTO;
using tpMTM.DAL;
using tpMTM.BO;

namespace tpMTM.UnitTests
{
    [TestClass]
    public class TestCreateNewPlayer
    {
        [TestMethod]
        public void TestCreateNew()
        {
            PlayerBO player = new PlayerBO();
            //adding comments to my unit tests
            //more comments
            player.AddPlayer("Kei Nishikori", "Japan", "", "");
            Assert.IsTrue(player.GetPlayerByName("Kei Nishikori").IsActive);
        }
    }
}
