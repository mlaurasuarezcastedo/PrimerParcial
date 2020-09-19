using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestSuarez.test
{
    [TestClass]
    public class UnitTestSuarez
    {
        [TestMethod]
        public void TestMethodGet()
        {
            //Arrange
            SuarezsController controller = new SuarezsController();

            //Act
            var Suarez = controller.GetSuarezs();

            //Assert
            Assert.IsNotNull(Suarez);
        }
    }
}
